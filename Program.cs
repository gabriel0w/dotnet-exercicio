using System;
using System.Collections;
using System.Collections.Generic;
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
            string[] filePaths = Directory.GetFiles(@"C:\Users\gabri\OneDrive\Área de Trabalho\dotnet_curso\inputs", "*.json");

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
