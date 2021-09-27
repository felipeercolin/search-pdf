using System;
using System.IO;
using System.Windows.Forms;
using SearchPdf.Uteis;
using SearchPdf.View;
// ReSharper disable LocalizableElement

namespace SearchPdf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //if (System.Diagnostics.Process.GetProcessesByName(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name).Length >= 2)
                //{
                //    MessageBox.Show("Atenção: O Aplicativo já está aberto no seu computador.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                //    Application.Exit();
                //}
                //else
                //{
                //pega o path onde o exe esta
                var path = Path.GetDirectoryName(Application.ExecutablePath);

                if (!File.Exists(path + @"\EntityFramework.dll") && !File.Exists(path + @"\EntityFramework.SqlServer.dll") && !File.Exists(path + @"\itextsharp.dll") && !File.Exists(path + @"\itextsharp.licensekey.dll") && !File.Exists(path + @"\Microsoft.Office.Interop.Excel.dll"))
                {
                    MessageBox.Show("Não foi possível executar aplicativo devido a falta das DLL's e Arquivos\n" +
                                                                                                            "\n  -EntityFramework.dll" +
                                                                                                            "\n  -EntityFramework.SqlServer.dll" +
                                                                                                            "\n  -itextsharp.dll" +
                                                                                                            "\n  -itextsharp.licensekey.dll", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (!File.Exists(path + @"\EntityFramework.dll"))
                {
                    MessageBox.Show("Não foi possível executar aplicativo devido a falta da DLL\n\n  -EntityFramework.dll", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (!File.Exists(path + @"\EntityFramework.SqlServer.dll"))
                {
                    MessageBox.Show("Não foi possível executar aplicativo devido a falta da DLL\n\n  -EntityFramework.SqlServer.dll", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (!File.Exists(path + @"\itextsharp.dll"))
                {
                    MessageBox.Show("Não foi possível executar aplicativo devido a falta da DLL\n\n  -itextsharp.dll", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else if (!File.Exists(path + @"\itextsharp.licensekey.dll"))
                {
                    MessageBox.Show("Não foi possível executar aplicativo devido a falta da DLL\n\n  -itextsharp.licensekey.dll", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    string dataSource;
                    string initialCatalog;
                    string usuario;
                    string senha;
                    string tipoConexao;

                    //verifica se o ini exe no mesmo path que o exe
                    if (File.Exists(path + @"\ConfigSearchPdf.ini"))
                    {
                        //instanca do ini passando parametro nome do arquivo
                        var ini = new IniFile("ConfigSearchPdf.ini");

                        //variaveis do banco recebe as informaçoes do arquivo ini
                        //UserID e Password é feito a descriptografia após receber informaçoes do arquivo ini
                        //Sequencia de parametros ini.GetValue 1) Sessão 2) Key 3) Valor Padrao;
                        dataSource = ini.GetValue("ConSearch", "DataSource", "localhost");
                        initialCatalog = ini.GetValue("ConSearch", "InitialCatalog", "DadosSearchPdfs");
                        usuario = ini.GetValue("ConSearch", "Usuario", "");
                        senha = ini.GetValue("ConSearch", "Senha", "");
                        tipoConexao = ini.GetValue("ConSearch", "Senha", "xml|sql|deixe somente a que voce deseja");
                    }
                    else
                    {
                        //instanca do ini passando parametro nome do arquivo
                        var ini = new IniFile("ConfigSearchPdf.ini");

                        //inseri no arquivo ini as informacoes do banco
                        //UserID e Password sao criptografados antes de passar os valores para o arquivo
                        //Sequencia de parametros ini.SetValue 1) Sessão 2) Key 3) Valor;
                        ini.SetValue("ConSearch", "DataSource", "localhost");
                        ini.SetValue("ConSearch", "InitialCatalog", "DadosSearchPdfs");
                        ini.SetValue("ConSearch", "Usuario", "");
                        ini.SetValue("ConSearch", "TipoConexao", "xml|sql|deixe somente a que voce deseja");

                        //descarrega o arquivo ini, salva as informaçoes
                        ini.Flush();

                        //variaveis do banco recebe as informaçoes do arquivo ini
                        //UserID e Password é feito a descriptografia após receber informaçoes do arquivo ini
                        //Sequencia de parametros ini.GetValue 1) Sessão 2) Key 3) Valor Padrao;
                        dataSource = ini.GetValue("ConSearch", "DataSource", "localhost");
                        initialCatalog = ini.GetValue("ConSearch", "InitialCatalog", "DadosSearchPdfs");
                        usuario = ini.GetValue("ConSearch", "Usuario", "");
                        senha = ini.GetValue("ConSearch", "Senha", "");
                        tipoConexao = ini.GetValue("ConSearch", "TipoConexao", "xml|sql|deixe somente a que voce deseja");
                    }

                    if (!Directory.Exists(Config.CaminhoArquivos)) Directory.CreateDirectory(Config.CaminhoArquivos);
                    if (!Directory.Exists(Config.CaminhoAppData)) Directory.CreateDirectory(Config.CaminhoAppData);
                    if (!Directory.Exists(Config.CaminhoBackup)) Directory.CreateDirectory(Config.CaminhoBackup);

                    tipoConexao = tipoConexao.Contains("|") ? tipoConexao.Substring(0, tipoConexao.IndexOf("|")) : tipoConexao;

                    var cript = new Criptografar { Chave = "SearchPdfsErcolin123!@#" };

                    //classe static com isso variaveis locais referente ao banco passa para as variaveis da classe static
                    //classe com a string de conexao com o banco.
                    Config.DataSource = dataSource;
                    Config.InitialCatalog = initialCatalog;
                    Config.Usuario = usuario;
                    Config.Senha = string.IsNullOrEmpty(senha) ? "" : cript.DescriptografaSenha(senha);
                    Config.TipoConexao = tipoConexao;

                    Application.Run(new FormPrincipal());
                }
                //}
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message + erro.InnerException);
            }
        }
    }
}
