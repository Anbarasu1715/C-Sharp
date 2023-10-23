using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XTrain
{

    public class student
    {
        public string name;
        public int age;

        //public string Name { get => name; set => name = value; }
    }

    class LamdaExpressions
    {
        public static void practice()
        {
            Console.WriteLine("Welcome");
            List<student> std = new List<student>();
            std.Add(new student { name = "anbu", age = 25 });
            std.Add(new student { name = "ferdin", age = 20 });
            std.Add(new student { name = "sudhakar", age = 18 });
            std.Add(new student { name = "Mani", age = 19 });
            Console.WriteLine(std[0].age);
            //var sortbyAge = std.OrderBy(a => a.age);
            foreach (student det in std)
            {
                Console.WriteLine(det.name + "  " + det.age);
            }

        }


    }
}
