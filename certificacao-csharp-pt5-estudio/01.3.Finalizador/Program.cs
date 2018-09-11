using System;
using System.Diagnostics;

namespace _01._3.Finalizador
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Livro livro = new Livro();
            }

            Console.ReadKey();
        }
    }

    class Livro
    {
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
    }
}
