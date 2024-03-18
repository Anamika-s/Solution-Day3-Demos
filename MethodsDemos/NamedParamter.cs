using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemos
{
    internal class NamedParamter
    {
        static void Main()
        {
            DisplayDetails(100, "ajay", "hr", 8, 80990.9f);


            DisplayDetails(exp: 10, name: "ajay", dept: "accts", id: 100, salary: 90000.5f);
        }
        static void DisplayDetails(int id , string name, string dept,
            int exp, float salary)
        {
            Console.WriteLine($"ID is {id}\n Name is {name}\n Dept is {dept}\n" +
                $"exp is {exp}\n Salary is {salary}");
        }
    }
}
