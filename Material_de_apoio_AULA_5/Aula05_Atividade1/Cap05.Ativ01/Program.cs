using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap05.Ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obter os valores
            Console.Write("Digite o valor do produto:");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            //Calcular
            //    Operadores:  +  -   *   /   %
            decimal resultado = quantidade * valor;

            //Exibir
            Console.WriteLine("Total da Compra:{0:c}", resultado);
            Console.ReadLine();


        }
    }
}
