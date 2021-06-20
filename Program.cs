using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo instance = new StudentInfo();
            instance.SetId("1000");
            instance.SetName("Divya");
            instance.SetMarks("70");
            string idValue = instance.GetId();
            string nameValue = instance.GetName();
            string marksValue = instance.GetMarks();
            System.Console.WriteLine(idValue);
            System.Console.WriteLine(nameValue);
            System.Console.WriteLine(marksValue);
            System.Console.ReadLine();
        }
    }
}
