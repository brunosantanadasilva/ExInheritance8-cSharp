using System.Globalization;
using ExInheritance8_cSharp.Entities;
using System.Globalization;
namespace ExInheritance8_cSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company ( i / c ) ? ");
                char ic = char.Parse(Console.ReadLine());
                while (ic != 'i' && ic != 'c')
                {
                    Console.Write("Individual or Company ( i / c ) ? ");
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: $ ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ic == 'i')
                {
                    Console.Write("Health expenditures: $");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number od employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
                Console.WriteLine();
            }
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;
            foreach (TaxPayer t in taxPayers)
            {
                Console.WriteLine(t);
                totalTaxes = totalTaxes + t.Tax();
            }
            Console.Write("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}