using System;
using System.IO;

namespace Aula12
{
    class Program
    {
        static void Main(string[] args)
        {

            var meusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = $@"{meusDocumentos}\teste.txt";

            using (var file = new StreamWriter(path, true))
            {
                file.WriteLine("Teste do Nano Degree");
                Console.WriteLine("Ok");
            }
        }
    }
}
