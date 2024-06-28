﻿using FactoryMethodDesignPattern_LiveExample.ConcreteProduct;
using FactoryMethodDesignPattern_LiveExample.Creator;
using FactoryMethodDesignPattern_LiveExample.Product;

namespace FactoryMethodDesignPattern_LiveExample.ConcreteCreator
{
    public class PushNotifierCreator : NotifierCreator
    {
        public override INotifier CreateNotifier()
        {
            return new PushNotifier();  
        }
    }
}
