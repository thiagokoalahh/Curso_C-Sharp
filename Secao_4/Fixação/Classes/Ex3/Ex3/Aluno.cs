using System;
using System.Globalization;

namespace Ex3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public void Resultado()
        {
            double notaFinal = Nota1 + Nota2 + Nota3;
            if (notaFinal >= 60)
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60 - notaFinal).ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
