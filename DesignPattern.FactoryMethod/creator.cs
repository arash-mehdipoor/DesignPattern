﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public abstract class creator
    {
        public abstract IProduct FactoryMethod(string type);
    }
}
