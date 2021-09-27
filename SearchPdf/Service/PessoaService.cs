using System.Collections.Generic;
using System.Globalization;
using SearchPdf.Interfaces;
using SearchPdf.Model;
using SearchPdf.NegocioEntity;
using SearchPdf.NegocioXml;
using SearchPdf.Uteis;

namespace SearchPdf.Service
{
    public class PessoaService : IBaseServiceNegocio<Pessoa>
    {
        public List<Pessoa> SelectTodos(bool desativa)
        {
            switch (Config.TipoConexao)
            {
                case "sql":
                    var pesNegocioEntity = new PessoaNegocioEntity();
                    return pesNegocioEntity.SelectTodos(desativa);
                case "xml":
                    var pesNegocioXml = new PessoaNegocioXml();
                    return pesNegocioXml.SelectTodos(desativa);
            }

            return new List<Pessoa>();
        }

        public List<Pessoa> SelectTodos(string nome, bool desativa)
        {
            switch (Config.TipoConexao)
            {
                case "sql":
                    var pesNegocioEntity = new PessoaNegocioEntity();
                    return pesNegocioEntity.SelectTodos(nome, desativa);
                case "xml":
                    var pesNegocioXml = new PessoaNegocioXml();
                    return pesNegocioXml.SelectTodos(nome, desativa);
            }

            return new List<Pessoa>();
        }

        public Pessoa SelectPorId(int id)
        {
            switch (Config.TipoConexao)
            {
                case "sql":
                    var pesNegocioEntity = new PessoaNegocioEntity();
                    return pesNegocioEntity.SelectPorId(id);
                case "xml":
                    var pesNegocioXml = new PessoaNegocioXml();
                    return pesNegocioXml.SelectPorId(id);
            }

            return null;
        }

        public Pessoa Save(Pessoa oPes)
        {
            if (oPes.Nome == "") return oPes;
            oPes.Nome = oPes.Nome == oPes.Nome.ToUpper() ? System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(oPes.Nome.ToLower()) : CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oPes.Nome);
            switch (Config.TipoConexao)
            {
                case "sql":
                    var pesNegocioEntity = new PessoaNegocioEntity();
                    return pesNegocioEntity.Save(oPes);
                case "xml":
                    var pesNegocioXml = new PessoaNegocioXml();
                    return pesNegocioXml.Save(oPes);
            }

            return oPes;
        }

        public bool UpdateAtivaDesativa(int id, bool desativa)
        {
            switch (Config.TipoConexao)
            {
                case "sql":
                    var pesNegocioEntity = new PessoaNegocioEntity();
                    return pesNegocioEntity.UpdateAtivaDesativa(id, desativa);
                case "xml":
                    var pesNegocioXml = new PessoaNegocioXml();
                    return pesNegocioXml.UpdateAtivaDesativa(id, desativa);
            }

            return false;
        }
    }
}
