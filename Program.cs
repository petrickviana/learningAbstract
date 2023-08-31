using Abstração.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace Abstração
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Person> list = new List<Person>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double inc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double hexp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Individual ind = new Individual(name, inc, hexp);
                    list.Add(ind);

                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numb = int.Parse(Console.ReadLine());

                    CorporateEntity corp = new CorporateEntity(name, inc, numb);
                    list.Add(corp);
                }
            }

            Console.WriteLine("TAXES PAID: ");

            double sum = 0;
            foreach (Person person in list)
            {
                Console.WriteLine(person.Name+ ": $ " + person.taxFee().ToString("F2", CultureInfo.InvariantCulture));
                sum += person.taxFee();
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
