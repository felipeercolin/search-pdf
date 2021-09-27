using System.Net.Mime;
using System.Windows.Forms;

namespace SearchPdf.Uteis
{
    public static class Config
    {
        public static string TipoConexao;
        public static string DataSource;
        public static string InitialCatalog;
        public static string Usuario;
        public static string Senha;

        public static string PathExecutavel => System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        public static string CaminhoBackup => PathExecutavel + @"\Backup";
        public static string CaminhoAppData => PathExecutavel + @"\App_Data";
        public static string CaminhoArquivos => PathExecutavel + @"\Arquivos";
    }
}
