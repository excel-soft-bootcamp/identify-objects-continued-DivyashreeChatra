using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBMI
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Console.WriteLine("Enter your height in meter:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg:");
            double weight = double.Parse(Console.ReadLine());

            double BMI = weight / height;

            if (BMI<18.5)
            {
                Console.WriteLine("Underweight");
            }
            if(BMI >=18.5 && BMI <=25)
            {
                Console.WriteLine("Normal");
            }
            if(BMI > 25)
            {
                Console.WriteLine("Overweight");
            }
            Console.WriteLine("BMI :" +BMI);
            Console.ReadLine();
        }

       
    }
}
