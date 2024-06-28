using FactoryMethodDesignPattern_LiveExample.Product;

namespace FactoryMethodDesignPattern_LiveExample.Creator
{
    public abstract class NotifierCreator
    {
        public abstract INotifier CreateNotifier();
    }
}
