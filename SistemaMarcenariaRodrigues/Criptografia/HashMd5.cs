using SistemaMarcenariaRodrigues.Log;
using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaMarcenariaRodrigues.Criptografia
{
    class HashMd5
    {
        public static string GerarMd5(string input)
        {
            try
            {
                MD5 md5Hash = MD5.Create();
                // Converter a String para array de bytes, que é como a biblioteca trabalha.
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                // Cria-se um StringBuilder para recompôr a string.
                StringBuilder sBuilder = new StringBuilder();

                // Loop para formatar cada byte como uma String em hexadecimal
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                return sBuilder.ToString();
            }
            catch (Exception ex)
            {
                RegistraLog.Log("Erro ao criptografar" + ex);
                return null;
            }
        }
    }
}
