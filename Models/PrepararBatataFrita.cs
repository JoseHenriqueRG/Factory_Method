using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Method.Models
{
    public class PrepararBatataFrita : Cozinha
    {
        public override ILanche FabricarLanche()
        {
            return new BatataFrita();
        }
    }
}
