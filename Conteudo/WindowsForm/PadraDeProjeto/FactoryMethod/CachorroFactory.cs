﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraDeProjeto.FactoryMethod
{
    internal class CachorroFactory : IAnimalFactory
    {
        public IAnimal CriarAnimal()
        {
            /*Cachorro c = new Cachorro();
            return c;*/
            return new Cachorro();
        }
    }
}
