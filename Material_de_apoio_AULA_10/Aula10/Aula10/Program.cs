using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando um objeto da classe Calculos
            //Criando uma instância da classe Calculos

            Calculos calc = new Calculos();
            int total = calc.Somar(1, 5,0);
            int resto = calc.Subtrair(10, 3);

            Console.WriteLine("Total:{0}", total);
            Console.WriteLine("Resto:{0}", resto);



            Produto prod = new Produto();
            prod.Nome = "a";
            prod.Preco = -10;

            Console.WriteLine("Nome:{0}", prod.Nome);
            Console.WriteLine("Preco:{0:c}", prod.Preco);



            Console.ReadLine();
        }
    }
}
