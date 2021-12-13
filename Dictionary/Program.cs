using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["usuario"] = "Maria";
            cookies["email"] = "Maria@gmail.com";
            cookies["telefone"] = "99123445";
            cookies["telefone"] = "83768273";

            Console.WriteLine(cookies["telefone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");
         
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("Não há chave email");
            }

            Console.WriteLine("Tamanho: " + cookies.Count);

            Console.WriteLine("Todos os cookies:");
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": "+item.Value);
            }

        }
    }
}
