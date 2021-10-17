using System;

namespace Ex1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);
        }
    }
}
