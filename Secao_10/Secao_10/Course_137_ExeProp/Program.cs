using System;
using System.Globalization;
using System.Collections.Generic;
using Course_137_ExeProp.Entities;

namespace Course_137_ExeProp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double taxes = 0.0;
            foreach(TaxPayer payer in taxPayers)
            {
                taxes += payer.Tax();
                Console.WriteLine($"{payer.Name}: $ " +
                    $"{payer.Tax().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + taxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
