using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnet_curso.Models;
using Newtonsoft.Json;
using System.Security.Permissions;

namespace dotnet_curso
{
    internal class Deserialize
    {
        public void Deserialization(string[] jsonString)
        {
            var fileContent = string.Empty;
            if (jsonString != null)
            {
                foreach (var path in jsonString)
                {
                    fileContent = File.ReadAllText(path, Encoding.GetEncoding("ISO-8859-1"));
                    var pessoa = JsonConvert.DeserializeObject<ModelJson>(fileContent);
                    Console.WriteLine(pessoa.Nome);
                    Console.WriteLine(pessoa.Telefone);
                }
            }
            else
            {
                Console.WriteLine("O caminho especificado não contem nenhum arquivo json");
            }
        }
    }
}
