using Empresa.Models;
using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente 
            {
                Id = 1,
                Nome = "Homer Simpson",
                Email = "homer@mail.com",
                Telefone = "23456987"
            };

            Console.WriteLine(cliente);
        }
    }
}
