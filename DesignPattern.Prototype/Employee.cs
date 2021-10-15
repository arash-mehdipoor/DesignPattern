using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public abstract class Employee
    {
        public abstract Employee Clone();

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
