using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface_task
{
    public class Bed : Furniture
    {
        public string cloth;
       
       
        public override void feature()
        {
            Console.WriteLine("Bed feature");
            Console.WriteLine($"color: {color}");
            Console.WriteLine($"cloth:{ cloth}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"MadeIn: {MadeIn}");


        }
    }
}
