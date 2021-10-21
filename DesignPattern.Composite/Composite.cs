using System;
using System.Collections.Generic;

namespace DesignPattern.Composite
{
    public class Composite : IComponent
    {

        private List<IComponent> _children = new List<IComponent>();
        private string Name = String.Empty;

        public Composite(string name)
        {
            this.Name = name;
        }


        public void Add(IComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IComponent component)
        {
            _children.Remove(component);
        }

        public void Display(int depth)
        {

            Console.WriteLine(new String('-', depth) + ' ' + Name);

            foreach (IComponent component in _children)
            {

                component.Display(depth + 2);

            }

        }
    }
}
