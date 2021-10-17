using System;

namespace Course_55
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            p.Nome = "TV 8K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            Produto p2 = p;
            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Preco);
            Console.WriteLine(p2.Quantidade);
            p.Nome = "Pamonha";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p2.Nome);


        }
    }
}
