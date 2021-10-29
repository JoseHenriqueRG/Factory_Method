using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Method.Models
{
    public abstract class Cozinha
    {
        public abstract ILanche FabricarLanche();

        public string PrepararLanche()
        {
            var lanche = FabricarLanche();

            var result = "OK " + lanche.MontarLanche();

            return result;
        }
    }
}
