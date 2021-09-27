using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SearchPdf.Context;
using SearchPdf.Interfaces;
using SearchPdf.Model;

namespace SearchPdf.NegocioEntity
{
    public class PessoaNegocioEntity : BaseNegocioEntity, IBaseServiceNegocio<Pessoa>
    {
        public List<Pessoa> SelectTodos(bool desativa)
        {
            using (var banco = new DadosSearchContext())
            {
                return banco.Pessoa.AsNoTracking()
                                   .Where(cd => cd.Desativa == desativa)
                                   .OrderBy(cd => cd.Nome)
                                   .Select(cd => new {cd.PessoaId, cd.Nome}).ToList()
                                   .Select(cd => new Pessoa
                                   {
                                       PessoaId = cd.PessoaId,
                                       Nome = cd.Nome,
                                   }).ToList();
            }
        }

        public List<Pessoa> SelectTodos(string nome, bool desativa)
        {
            using (var banco = new DadosSearchContext())
            {
                return banco.Pessoa.AsNoTracking()
                                       .Where(cd => cd.Nome.Contains(nome) && cd.Desativa == desativa)
                                       .OrderBy(cd => cd.Nome).ToList()
                                       .Select(cd => new Pessoa
                                       {
                                           PessoaId = cd.PessoaId,
                                           Nome = cd.Nome,
                                           Desativa = cd.Desativa,
                                           Cadastro = cd.Cadastro
                                       }).ToList(); 
            }
        }

        public Pessoa SelectPorId(int pessoaId)
        {
            using (var banco = new DadosSearchContext())
            {
                return banco.Pessoa.AsNoTracking()
                                       .Where(cd => cd.PessoaId == pessoaId).ToList()
                                       .Select(cd => new Pessoa
                                       {
                                           PessoaId = cd.PessoaId,
                                           Nome = cd.Nome,
                                           Desativa = cd.Desativa,
                                           Cadastro = cd.Cadastro
                                       }).FirstOrDefault(); 
            }
        }

        public Pessoa Save(Pessoa oPes)
        {
            using (var banco = new DadosSearchContext())
            {
                try
                {
                    if (oPes.PessoaId > 0)
                    {
                        var objPes = banco.Pessoa.FirstOrDefault(cd => cd.PessoaId == oPes.PessoaId);
                        if (objPes == null) return oPes;

                        banco.Entry(objPes).State = EntityState.Modified;
                        objPes.Nome = oPes.Nome;

                        oPes = objPes;
                    }
                    else
                    {
                        banco.Entry(oPes).State = EntityState.Added;
                        oPes.Desativa = false;
                        oPes.Cadastro = BancoNegocioEntity.GetDate();

                        banco.Pessoa.Add(oPes);
                    }
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message);
                } 
               
                SaveChanges(banco);

                return oPes;
            }
        }

        public bool UpdateAtivaDesativa(int pessoaId, bool desativa)
        {
            using (var banco = new DadosSearchContext())
            {
                try
                {
                    var objPes = banco.Pessoa.FirstOrDefault(cd => cd.PessoaId == pessoaId);
                    if (objPes == null) return false;

                    banco.Entry(objPes).State = EntityState.Modified;

                    objPes.Desativa = desativa;
                }
                catch (Exception erro)
                {
                    throw new Exception(erro.Message);
                }

                SaveChanges(banco);

                return true;
            }
        }
    }
}
