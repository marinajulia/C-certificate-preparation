using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Programming.Manipulação_de_string
{
    public class String_Writer
    {
        public void Executar()
        {
            string ingredientes = GetIngredientes();

            Console.OutputEncoding = Encoding.UTF8;

            using StringWriter stringWriter = new StringWriter();
            {
                using (StringReader stringReader = new StringReader(ingredientes))
                {
                    string line;

                    while ((line = stringReader.ReadLine()) != null)
                    {
                        stringWriter.WriteLine("• " + line);
                    }
                    Console.ReadKey();
                }
                Console.WriteLine(stringWriter);
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

