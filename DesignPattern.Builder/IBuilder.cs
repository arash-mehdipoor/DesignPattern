using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    public interface IBuilder
    {
        void BuildScreen();
        void BuildOS();
        public Product Product { get; }
    }
}
