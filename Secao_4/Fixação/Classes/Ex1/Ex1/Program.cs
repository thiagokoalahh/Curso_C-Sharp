using System;
using System.Globalization;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do triângulo:");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Área = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
