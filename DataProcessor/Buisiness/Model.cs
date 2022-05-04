using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataProcessor
{
    public class Binary : IData
    {
        private String _filePath;
        public Binary( String filepath)
        {
            _filePath = filepath;
        }
            
        public string GetDataType()
        {
            return "binary";
        }

        public string ProcessData()
        {
            String character = System.Text.RegularExpressions.Regex.Replace(File.ReadAllText(_filePath), "[^01]", "");
            byte[] arr = new byte[(character.Length/8)-1+1];
            for (int i = 0; i < 4; i++)
            {
                arr[i] = Convert.ToByte(character.Substring(i * 8,8),2);
            }
            return Encoding.UTF8.GetString(arr);
        }
    }

    public class Text : IData
    {
        private String _filePath;
        public Text(String filepath)
        {
            _filePath = filepath;
        }

        public string GetDataType()
        {
            return "text";
        }

        public string ProcessData()
        {
            var arr = File.ReadAllBytes(_filePath);
            return Encoding.UTF8.GetString(arr).Substring(0,6);
        }
    }
    public class TextReverse : IData
    {
        private String _filePath;
        public TextReverse(String filepath)
        {
            _filePath = filepath;
        }

        public string GetDataType()
        {
            return "textreverse";
        }

        public string ProcessData()
        {
            var txt = File.ReadAllText(_filePath);
            return String.Join("",txt.Take(5).Reverse());
        }
    }
}
