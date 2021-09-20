using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06.ativ01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formas de Pagamento
            //Se o valor da compra for maior que R$1.000,00 pode parcelar em 3 vezes
            //Se não for, apenas a vista

            decimal valorCompra;
            int numeroParcelas = 3;
            decimal valorParcela;
            decimal ValorMinimoParcelar = 1000.01m;

            Console.Write("Digite o valor da compra:");
            valorCompra = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Valor a vista: {0:c}", valorCompra);

            if (valorCompra >= ValorMinimoParcelar)
            {
                valorParcela = valorCompra / numeroParcelas;
                Console.WriteLine("Pode ser parcelado em {0} vezes. Valor da Parcela:{1:c}",
                                         numeroParcelas, valorParcela);
            }
            Console.ReadLine();

        }
    }
}
