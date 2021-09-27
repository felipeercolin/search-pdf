
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using SearchPdf.Interfaces;
using SearchPdf.Model;
using SearchPdf.Uteis;

namespace SearchPdf.NegocioXml
{
    public class PessoaNegocioXml : BaseNegocioXml, IBaseServiceNegocio<Pessoa>
    {
        public PessoaNegocioXml()
        {
            LoadXml();
        }

        public int GetProximoId()
        {
            var listPessoas = DadosXml.Element("pessoas")?.Elements().Select(cd => new Pessoa { PessoaId = Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0") })
                                                                     .OrderBy(cd => cd.PessoaId).ToList() ?? new List<Pessoa>();

            return listPessoas.Count == 0 ? 1 : listPessoas.Max(cd => cd.PessoaId) + 1;
        }

        public List<Pessoa> SelectTodos(bool desativa)
        {
            return DadosXml.Element("pessoas")?.Elements().Where(cd => (cd.Attribute("desativa")?.Value ?? "false").ToLower() == (desativa ? "true" : "false"))
                                      .Select(cd => new Pessoa
                                      {
                                          PessoaId = Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0"),
                                          Nome = cd.Attribute("nome")?.Value ?? ""
                                      }).OrderBy(cd => cd.Nome).ToList();
        }

        public List<Pessoa> SelectTodos(string nome, bool desativa)
        {
            return DadosXml.Element("pessoas")?.Elements().Where(cd => Util.Contains(cd.Attribute("nome")?.Value ?? "", nome, StringComparison.OrdinalIgnoreCase) && (cd.Attribute("desativa")?.Value ?? "false").ToLower() == (desativa ? "true" : "false"))
                                                          .Select(cd => new Pessoa
                                                          {
                                                              PessoaId = Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0"),
                                                              Nome = cd.Attribute("nome")?.Value ?? "",
                                                              Desativa = (cd.Attribute("desativa")?.Value ?? "false") == "true",
                                                              Cadastro = Convert.ToDateTime(cd.Attribute("cadastro")?.Value ?? "01/01/01")
                                                          }).OrderBy(cd => cd.Nome).ToList();
        }

        public Pessoa SelectPorId(int id)
        {
            return DadosXml.Element("pessoas")?.Elements().Where(cd => Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0") == id)
                                      .Select(cd => new Pessoa
                                      {
                                          PessoaId = Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0"),
                                          Nome = cd.Attribute("nome")?.Value ?? "",
                                          Desativa = (cd.Attribute("desativa")?.Value ?? "false") == "true",
                                          Cadastro = Convert.ToDateTime(cd.Attribute("cadastro")?.Value ?? "01/01/01")
                                      }).FirstOrDefault();
        }

        public Pessoa Save(Pessoa oPes)
        {
            try
            {
                if (oPes.PessoaId > 0)
                {
                    var objElement = DadosXml.Element("pessoas")?.Elements().FirstOrDefault(cd => Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0") == oPes.PessoaId);
                    if (objElement == null) return oPes;

                    objElement.Attribute("nome")?.SetValue(oPes.Nome);
                }
                else
                {
                    oPes.PessoaId = GetProximoId();
                    var element = new XElement("pessoa");
                    element.Add(new XAttribute("codigo", oPes.PessoaId + ""));
                    element.Add(new XAttribute("nome", oPes.Nome));
                    element.Add(new XAttribute("desativa", (oPes.Desativa ?? false) ? "true" : "false"));
                    element.Add(new XAttribute("cadastro", DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString()));
                    AddElementFilhos("pessoas", element);
                }

                SaveDados();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            return oPes;
        }

        public bool UpdateAtivaDesativa(int id, bool desativa)
        {
            try
            {
                var objElement = DadosXml.Element("pessoas")?.Elements().FirstOrDefault(cd => Convert.ToInt32(cd.Attribute("codigo")?.Value ?? "0") == id);
                if (objElement == null) return false;

                objElement.Attribute("desativa")?.SetValue(desativa ? "true" : "false");

                SaveDados();

                return true;
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
