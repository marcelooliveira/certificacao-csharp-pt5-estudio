using System;
using System.IO;

namespace _02._3.string_writer
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredientes = GetIngredientes();

            using (var stringWriter = new StringWriter())
            {
                using (var stringReader = new StringReader(ingredientes))
                {
                    string linha = string.Empty;
                    while ((linha = stringReader.ReadLine()) != null)
                    {
                        stringWriter.WriteLine(linha);
                    }
                }
                Console.WriteLine(stringWriter);
            }

            Console.ReadKey();
        }

        private static string GetIngredientes()
        {
            return @"3 cenouras médias raspadas e picadas
3 ovos
1 xícara de óleo
2 xícaras de açúcar
2 xícaras de farinha de trigo
1 colher(sopa) de fermento em pó
1 pitada de sal";
        }
    }
}
