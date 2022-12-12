using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace dotnet_curso
{
    class Program
    {
        private static string[] GetInputList()
        {
            string[] filePaths = Directory.GetFiles(@"..\..\..\inputs", "*.json");

            return filePaths;
        }
        static void Main(string[] args)
        {
            var paths = GetInputList();
            var instDeserialize = new Deserialize();

            instDeserialize.Deserialization(paths);
        }
    }
}
