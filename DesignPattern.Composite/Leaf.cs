using System;

namespace DesignPattern.Composite
{
    public class Leaf: IComponent
    {
        private string Name = string.Empty;

        public Leaf(string name)
        {
            this.Name = name;
        }

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + ' ' + Name);
        }
    }
}
