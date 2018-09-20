using System;

namespace _02._6_formatar
{
    public class Program
    {
        public static void Main()
        {
            var deLorean = new DeLorean();
            Console.WriteLine(deLorean);

            Console.ReadKey();
        }
    }

    class DeLorean
    {
        public CapacitorDeFluxo Capacitor { get; } = new CapacitorDeFluxo();

        public override string ToString()
        {
            return 
                "DeLorean DMC-12\r\n"
                + "===============\r\n"
                + "\r\n" + Capacitor;
        }
    }

    class CapacitorDeFluxo
    {
        public const double VELOCIDADE_MPH = 88; //milhas por hora
        public const double KMH_PARA_MPH = 1.60934; //fator de conversão para KMH

        public override string ToString()
        {
            return 
                "Capacitor de fluxo\r\n"
                + "=================\r\n"
                + "Velocidade mínima:\r\n"
                + "\tEm milhas por hora:      " + VELOCIDADE_MPH + " MPH\r\n"
                + "\tEm quilômetros por hora: " + VELOCIDADE_MPH * KMH_PARA_MPH + " KMH";
        }
    }
}


