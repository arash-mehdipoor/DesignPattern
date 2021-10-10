using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public sealed class SingletonClassCreator<T> where T : class, new()
    {
        private static T _singletoneInstance;
        private static readonly object Lock = new object();
        private SingletonClassCreator() { }

        public static T SingletoneInstance
        {
            get
            {
                lock (Lock)
                {
                    if (_singletoneInstance == null)
                    {
                        _singletoneInstance = new T();
                    }
                    return _singletoneInstance;
                }
            }
        }
    }
}
