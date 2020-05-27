using System;
using System.Collections.Generic;
using System.Globalization;
using TaxPayer.Entities;

namespace TaxPayer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayers> taxPayers = new List<TaxPayers>();

            Console.Write("Enter the number of tax payers: ");
            int payers = int.Parse(Console.ReadLine());
            
            for(int n = 1 ; n <= payers; n++)
            {
                Console.WriteLine($"Tax payer #{n} data: ");
                Console.Write("Individual or company (i/c)? ");
                char typePayer = char.Parse(Console.ReadLine());

                if (typePayer == char.Parse("i"))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    taxPayers.Add(new Individual(name, income, health));
                } else if( typePayer == char.Parse("c"))
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, income, employees));
                } else
                {
                    Console.WriteLine("Option invalid");
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTax = 0.0;
            foreach(TaxPayers tax in taxPayers)
            {
                totalTax += tax.Tax();
                Console.Write(tax);
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + totalTax.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
