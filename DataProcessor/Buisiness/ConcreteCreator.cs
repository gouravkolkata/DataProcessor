using System;

namespace DataProcessor
{
    public class BinaryFactory : DataFactory
    {
        private String _filePath;
        public BinaryFactory(String filePath)
        {
            this._filePath = filePath;
        }
        protected override IData MakeProduct()
        {
            IData product = new Binary(_filePath);
            return product;
        }
    }
    public class TextFactory : DataFactory
    {
        private String _filePath;
        public TextFactory(String filePath)
        {
            this._filePath = filePath;
        }
        protected override IData MakeProduct()
        {
            IData product = new Text(_filePath);
            return product;
        }
    }
    public class TextReverseFactory : DataFactory
    {
        private String _filePath;
        public TextReverseFactory(String filePath)
        {
            this._filePath = filePath;
        }
        protected override IData MakeProduct()
        {
            IData product = new TextReverse(_filePath);
            return product;
        }
    }
}
