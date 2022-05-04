using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
    public abstract class DataFactory
    {
        protected abstract IData MakeProduct();
        public IData CreateProduct()
        {
            return MakeProduct();
        }
    }
}
