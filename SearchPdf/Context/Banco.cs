using SearchPdf.Uteis;

namespace SearchPdf.Context
{
    public static class Banco
    {
        public static string StringConexao => string.Format(@"Data Source={0};{1}{2}Integrated Security={3};{4}{5}Connect Timeout=60;",
                                                            Config.DataSource, 
                                                            NetworkLibrary, 
                                                            Config.DataSource.Contains("localhost") || Config.DataSource.Contains(@".\") || Config.DataSource.Contains("(LocalDB)") ? "" : string.Format("Initial Catalog={0};", Config.InitialCatalog),
                                                            IntegratedSecurity,
                                                            string.IsNullOrEmpty(Config.Usuario) && string.IsNullOrEmpty(Config.Senha) ? "" : string.Format("User ID={0};", Config.Usuario),
                                                            string.IsNullOrEmpty(Config.Usuario) && string.IsNullOrEmpty(Config.Senha) ? "" : string.Format("Password={0};", Config.Senha)
                                                            );
       
        private static string IntegratedSecurity => string.IsNullOrEmpty(Config.Usuario) && string.IsNullOrEmpty(Config.Senha) ? "True" : "False";
        private static string NetworkLibrary => Config.DataSource.Contains("localhost") || Config.DataSource.Contains(@".\") || Config.DataSource.Contains("(LocalDB)") 
                                                        ? "" 
                                                : " Network Library=DBMSSOCN; ";

    }
}
