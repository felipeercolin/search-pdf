
using System;

namespace SearchPdf.Model
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public bool? Desativa { get; set; }
        public DateTime? Cadastro { get; set; }
    }
}
