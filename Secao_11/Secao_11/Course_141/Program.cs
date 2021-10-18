using System;

namespace Course_141
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Encerrando...");
            }
        }
    }
}
