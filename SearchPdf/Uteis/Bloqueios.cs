using System.Windows.Forms;

namespace SearchPdf.Uteis
{
    public static class Bloqueios 
    {
        public static bool SomenteNumero(object sender, KeyPressEventArgs e)
        {
            var value = new bool();
            var asc = (int)e.KeyChar;

            if (!char.IsDigit(e.KeyChar) && asc != 08 && asc != 127)
            {
                value = true;
            }

            return value;
        } 
    }
}
