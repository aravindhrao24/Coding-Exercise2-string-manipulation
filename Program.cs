using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static void Main(string[] args)
        {
            int employeeid = 20;
            string CompanyName = "UTCLI";
            Console.WriteLine("string concatenation");
            Console.WriteLine("hello my employee ID is " + employeeid + " my company name is " + CompanyName);
            Console.WriteLine("string composite");
            Console.WriteLine("Hello, my employee ID is {0} and my company name is {1}", employeeid, CompanyName);
            Console.WriteLine("String interpolation");
            Console.WriteLine($"Hello my employee ID is {employeeid},my company name is {CompanyName}");

        } 

    }
}
