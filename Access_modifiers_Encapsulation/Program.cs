using System;

namespace Access_modifiers_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter count:");
            int count = Convert.ToInt32(Console.ReadLine());
            Engineer[] engineers =new Engineer[count];

            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine("\nPlease enter Fullname:");
                string fullname = Console.ReadLine();
                Console.WriteLine("\nPlease enter Salary:");
                double salaryValue = Convert.ToDouble(Console.ReadLine());

                Engineer engr = new Engineer(fullname, salaryValue);
                engineers[i] = engr;
            }

            double sum = 0;
            for (int i = 0; i < engineers.Length; i++)
            {
                sum += engineers[i].Salary;
            }
            Console.Write("\nAverageResult:\n"+sum/engineers.Length);
        }

    }
}
