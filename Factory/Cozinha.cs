using Factory_Method.Interfaces;

namespace Factory_Method.Factory
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
