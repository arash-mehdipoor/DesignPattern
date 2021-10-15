using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public class Developer : Employee
    {
        public string Language { get; set; }
        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}",Name,Age,Language);
        }
    }
}
