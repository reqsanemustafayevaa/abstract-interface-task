using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface_task
{
    public class Table : Furniture
    {
        public string material;
       
        public override void feature()
        {
            Console.WriteLine("Table feature");
           Console.WriteLine($"color:{color}");
            Console.WriteLine($"material: { material}");
            Console.WriteLine($"Price:{Price}");
            Console.WriteLine($"MadeIn:{MadeIn}");
        }
    }
}
