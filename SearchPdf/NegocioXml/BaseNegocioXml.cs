
using System.IO;
using System.Xml.Linq;
using SearchPdf.Uteis;

namespace SearchPdf.NegocioXml
{
    public class BaseNegocioXml
    {
        public static string Caminho => Config.CaminhoAppData + @"\Dados.xml";
        public XDocument DadosXml;

        public void CreateXml()
        {
            if (File.Exists(Caminho)) return;
            DadosXml = XDocument.Parse(@"<pessoas></pessoas>");
            SaveDados();
        }

        public void AddElementPai(string nomeElementPai)
        {
            LoadXml();
            DadosXml.Add(nomeElementPai);
            SaveDados();
        }

        public void LoadXml()
        {
            DadosXml = XDocument.Load(Caminho);
        }

        public void AddElementFilhos(string nomeElementPai, XElement element)
        {
            DadosXml.Element(nomeElementPai)?.Add(element);
        }

        public void SaveDados()
        {
            DadosXml.Save(Caminho);
        }
    }
}
