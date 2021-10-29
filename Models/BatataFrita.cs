using Factory_Method.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Factory_Method.Models
{
    public class BatataFrita : ILanche
    {
        public string MontarLanche()
        {
            return "Batata Frita pronta!";
        }
    }
}
