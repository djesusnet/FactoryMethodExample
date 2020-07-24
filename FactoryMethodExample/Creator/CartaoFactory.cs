using FactoryMethodExample.Product;

namespace FactoryMethodExample.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}
