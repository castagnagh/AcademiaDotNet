﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraDeProjeto.FactoryMethod
{
    internal interface IAnimalFactory
    {
        IAnimal CriarAnimal();
    }
}
