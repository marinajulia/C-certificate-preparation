using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programming.Manipulação_de_string
{
    public class StringRead
    {
        public void Executar()
        {
            string ingredientes = GetIngredientes();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (StringReader stringReader = new StringReader(ingredientes))
            {
                string line;

                while ((line = stringReader.ReadLine()) != null)
                {
                    Console.WriteLine("• " + line);
                }
                Console.ReadKey();
            }
        }
        private static string GetIngredientes()
        {
            return @"ovo
farinha
açucar
leite";
        }
    }
}
