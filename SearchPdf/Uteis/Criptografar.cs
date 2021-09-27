using System;
using System.Security.Cryptography;
using System.Text;

namespace SearchPdf.Uteis
{
    public class Criptografar
    {
        private string _chave;
        
        public string Chave
        {
            set
            {
                _chave = value;
            }
        }

        public string CriptografaSenha(string senhaCripto)
        {
            try
            {
                return CriptografaSenha(senhaCripto, _chave);
            }
            catch (Exception ex)
            {
                return string.Format("String errada.{0}", ex.Message);
            }

        }

        public string DescriptografaSenha(string senhaDescripto)
        {
            try
            {
                return DescriptografaSenha(senhaDescripto, _chave);
            }
            catch (Exception ex)
            {
                return string.Format("String errada.{0}", ex.Message);
            }
        }

        private static string CriptografaSenha(string senhaCripto, string chave)
        {
            try
            {
                var objcriptografaSenha = new TripleDESCryptoServiceProvider();
                var objcriptoMd5 = new MD5CryptoServiceProvider();

                var strTempKey = chave;

                var byteHash = objcriptoMd5.ComputeHash(Encoding.ASCII.GetBytes(strTempKey));
                objcriptografaSenha.Key = byteHash;
                objcriptografaSenha.Mode = CipherMode.ECB;

                var byteBuff = Encoding.ASCII.GetBytes(senhaCripto);
                return Convert.ToBase64String(objcriptografaSenha.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
            }
            catch (Exception ex)
            {
                return string.Format("Digite os valores Corretamente : {0}", ex.Message);
            }
        }


        private static string DescriptografaSenha(string strCriptografada, string chave)
        {
            try
            {
                var objdescriptografaSenha = new TripleDESCryptoServiceProvider();
                var objcriptoMd5 = new MD5CryptoServiceProvider();

                var strTempKey = chave;

                var byteHash = objcriptoMd5.ComputeHash(Encoding.ASCII.GetBytes(strTempKey));
                objdescriptografaSenha.Key = byteHash;
                objdescriptografaSenha.Mode = CipherMode.ECB;

                var byteBuff = Convert.FromBase64String(strCriptografada);
                var strDecrypted = Encoding.ASCII.GetString(objdescriptografaSenha.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));

                return strDecrypted;
            }
            catch (Exception ex)
            {
                return string.Format("Digite os valores Corretamente : {0}", ex.Message);
            }
        }

        public bool CompararStrings(string num01, string num02)
        {
            return num01.Equals(num02);
        }
    }
}
