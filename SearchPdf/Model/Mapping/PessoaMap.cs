
using System.Data.Entity.ModelConfiguration;

namespace SearchPdf.Model.Mapping
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        public PessoaMap()
        {
            HasKey(cd => cd.PessoaId);

            Property(cd => cd.Nome).HasMaxLength(50).IsRequired().IsUnicode(false);

            ToTable("Pessoa");
        }
    }
}
