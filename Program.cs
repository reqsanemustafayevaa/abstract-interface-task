using System.Runtime.InteropServices;

namespace abstract_interface_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Table table = new Table();
            Bed bed = new Bed();
            table.color = "black";
            table.material = "wooden";
            table.Price =3000;
            table.MadeIn = "turkey";
            table.feature();
           
            bed.color = "white";
            bed.cloth = "cotton";
            bed.Price = 2500;
            bed.MadeIn = "China";
            bed.feature();
            Console.ReadLine();
        }
    }
}