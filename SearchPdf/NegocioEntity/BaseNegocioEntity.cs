using System;
using System.Data.Entity.Validation;
using SearchPdf.Context;

namespace SearchPdf.NegocioEntity
{
    public class BaseNegocioEntity
    {
        public void SaveChanges(DadosSearchContext banco)
        {
            try
            {
                banco.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                var errors = "";
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        errors = string.Format("Campo: {0} Erro: {1}", validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }

                throw new Exception(errors);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message + erro.InnerException);
            }
        }
    }
}
