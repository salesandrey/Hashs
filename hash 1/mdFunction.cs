using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Cadastro
{
    public class mdFunction
    {
        private MD5 hashMd;
        public MD5 getHas { get { return hashMd; } set { hashMd = value; } }
        public mdFunction()
        {
            hashMd = MD5.Create();

        }

        public String getMD5hash(MD5 Myhash,string text)
        {
            byte[] dado = Myhash.ComputeHash(Encoding.UTF8.GetBytes(text));
            
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i< dado.Length;i++)
            {
                builder.Append(dado[i].ToString("X2"));
            }
            return builder.ToString();
        }

        public bool checkHash(MD5 myshash, string text, string hash)
        {
            string createNewHash = getMD5hash(myshash, text);
            StringComparer comparador = StringComparer.OrdinalIgnoreCase;

            if(0 == comparador.Compare(hash,createNewHash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}