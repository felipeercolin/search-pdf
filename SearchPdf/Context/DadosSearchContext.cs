using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SearchPdf.Model;
using SearchPdf.Model.Mapping;

namespace SearchPdf.Context
{
    public class DadosSearchContext : DbContext
    {
        public DadosSearchContext():base(Banco.StringConexao)
        {
        }

        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PessoaMap());


            //Aqui vamos remover a pluralização padrão do Etity Framework que é em inglês
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            /*Desabilitamos o delete em cascata em relacionamentos 1:N evitando
             ter registros filhos     sem registros pai*/
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //Basicamente a mesma configuração, porém em relacionamenos N:N
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Toda propriedade que tem um "Id" é a chave primaria
            modelBuilder.Properties().Where(cd => cd.Name == cd.ReflectedType.Name + "Id");

            /*Toda propriedade do tipo string na entidade POCO
             seja configurado como VARCHAR no SQL Server*/
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            /*Toda propriedade do tipo string na entidade POCO seja configurado como VARCHAR (50) no banco de dados */
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(50));
        }
    }
}
