using System;
using System.Globalization;

namespace Course_69 {
    class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] vect = new double[3];

            double sum = 0.0;
            for(int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            double media = sum / n;
            Console.WriteLine("Altura Media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
