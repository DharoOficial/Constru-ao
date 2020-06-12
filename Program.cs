using System;

namespace Construçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro("Bughatti", "veriom");
            Carro carro3 = new Carro("henesey", "venonGT", 2014, "cinza");

            System.Console.WriteLine(carro2.marca);
            System.Console.WriteLine(carro2.modelo);
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine(carro3.marca);
            System.Console.WriteLine(carro3.modelo);
            System.Console.WriteLine(carro3.ano);
            System.Console.WriteLine(carro3.cor);
        }
    }
}
