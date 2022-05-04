using System;

namespace DataProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryPath = @"C:\Users\Pankaj\source\repos\DataProcessor\DataProcessor\Data\binary.txt";
            var textPath = @"C:\Users\Pankaj\source\repos\DataProcessor\DataProcessor\Data\normal.txt";
            Manager m = new Manager();
            var data = m.Get("binary", binaryPath);
            if (data != null)
            {
                Console.WriteLine("File type : " +data.GetDataType());
                Console.WriteLine("Data Process o/p : "+data.ProcessData());
            }
            data = m.Get("text", textPath);
            if (data != null)
            {
                Console.WriteLine("File type : " + data.GetDataType());
                Console.WriteLine("Data Process o/p : " + data.ProcessData());
            }
            data = m.Get("textreverse", textPath);
            if (data != null)
            {
                Console.WriteLine("File type : " + data.GetDataType());
                Console.WriteLine("Data Process o/p : " + data.ProcessData());
            }
            Console.ReadLine();
        }
    }
}
