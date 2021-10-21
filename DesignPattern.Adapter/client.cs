using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Adapter
{
    public class client
    {
        private ITarget _target;
        public client(ITarget target)
        {
            _target = target;
        }

        public void MakeRequest()
        {
            _target.MethodA();
        }
    }

    public interface ITarget
    {
        void MethodA();
    }

    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB");
        }
    }

    public class Adapter : ITarget
    {
        Adaptee adaptee = new Adaptee();

        public void MethodA()
        {
            adaptee.MethodB();
        }
    }
}
