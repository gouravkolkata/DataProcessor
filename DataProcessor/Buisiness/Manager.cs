using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessor
{
    public class Manager
    {
        public IData Get(String type, String path)
        { 
            switch (type.ToLower())
            {
                case "binary":
                    return new BinaryFactory(path).CreateProduct();
                case "text":
                    return new TextFactory(path).CreateProduct();
                case "textreverse":
                    return new TextReverseFactory(path).CreateProduct();
                default:
                    return null;
            }
        }    
    }
}
