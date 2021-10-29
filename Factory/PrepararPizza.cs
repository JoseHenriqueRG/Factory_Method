using Factory_Method.Interfaces;
using Factory_Method.Models;

namespace Factory_Method.Factory
{
    public class PrepararPizza : Cozinha
    {
        public override ILanche FabricarLanche()
        {
            return new Pizza();
        }
    }
}
