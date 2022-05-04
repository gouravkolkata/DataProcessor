using System;

namespace DataProcessor
{
    public interface IData
    {
        String GetDataType();
        String ProcessData();
    }
}
