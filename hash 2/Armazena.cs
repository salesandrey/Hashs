using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

namespace Cadastro
{
    public class Armazena
    {

        
        public void gravar(String nome, String hash)
        {
            FileStream fs = new FileStream(@"C:\Users\sales\source\repos\WebApplication6\WebApplication6\Cadastro.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(nome +'/'+ hash);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public bool ler(String nome, String senha)
        {
            
            String path = @"C:\Users\sales\source\repos\WebApplication6\WebApplication6\Cadastro.txt";
            List<String> lines = File.ReadAllLines(path).ToList();

            foreach(String a in lines)
            {
                string b = a.Substring(0,a.IndexOf('/'));
                string c = a.Substring(a.IndexOf('/')+1, 32);
                Console.WriteLine(c);
                Console.WriteLine(b);
                if(nome==b)
                {
                    int d = a.IndexOf('/');
                    int e = a.Length;
                    
                    Console.WriteLine(c);
                    return CompararHash(c,senha);
                }
            }
            return false;
            
        }

        public bool CompararHash(String c, String senha)
        {
            mdFunction mdf = new mdFunction();

            if(mdf.checkHash(mdf.getHas,senha,c))
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