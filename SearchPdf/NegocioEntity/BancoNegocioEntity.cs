using System;
using System.Linq;
using SearchPdf.Context;

namespace SearchPdf.NegocioEntity
{
    public class BancoNegocioEntity : BaseNegocioEntity
    {
        /// <summary>
        /// Metodo Retorna a Data e Hora do Servidor.
        /// Código criado para Estrutura do Entity Framework
        /// </summary>
        /// <returns>DataTime</returns>
        public static DateTime GetDate()
        {
            try
            {
                return new DadosSearchContext().Database.SqlQuery<DateTime>("SELECT GETDATE()").First();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
        }
    }
}
