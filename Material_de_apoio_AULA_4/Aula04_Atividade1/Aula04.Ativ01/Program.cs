﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04.Ativ01
{
    //Classe
    class Program
    {
        //Método principal
        static void Main(string[] args)
        {
            //Somar dois numeros
            int n1, n2, resultado;

            //Obtendo os Valores
            Console.Write("Digite o número 1:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2:");
            n2 = Convert.ToInt32(Console.ReadLine());

            //Processar
            resultado = n1 + n2;

            //Exibir
            Console.WriteLine("A soma de {0} e {1} é {2}", n1, n2, resultado);
            Console.ReadLine();


        }
    }
}
