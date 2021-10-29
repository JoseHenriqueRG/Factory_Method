using Factory_Method.Interfaces;
using Factory_Method.Models;

namespace Factory_Method.Factory
{
    public class PrepararBatataFrita : Cozinha
    {
        public override ILanche FabricarLanche()
        {
            return new BatataFrita();
        }
    }
}
