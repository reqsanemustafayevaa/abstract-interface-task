using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_interface_task
{
    public abstract class Furniture
    {
        public string color;
        public string MadeIn;
        public double Price;
        abstract public void feature();
    }
}
