using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09.Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<T>
            //Queue<T>
            //Stack<T>
            //Dictionary<T>


            Dictionary<string, string> dados = new Dictionary<string, string>();

            dados.Add("Nome", "José da Silva");
            dados.Add("RG", "23.234.1234");
            dados.Add("Telefone", "(11) 5555-2323");

            Console.WriteLine(dados["Nome"]);
            Console.WriteLine(dados["RG"]);
            Console.WriteLine(dados["Telefone"]);





            /*
            //Pilha FILO   First in Last Out
            Stack<string> pilha = new Stack<string>();
            pilha.Push("Processo 1");
            pilha.Push("Processo 2");

            while (pilha.Count > 0)
            {
                string item = pilha.Pop();
                Console.WriteLine(item);
            }
            */


            /*
            //Fila   FIFO First In First Out
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Processo 1");
            fila.Enqueue("Processo 2");
            fila.Enqueue("Processo 3");

            while (fila.Count > 0)
            {
                string item=fila.Dequeue();
                Console.WriteLine(item);
            }
            */

            /*
            List<string> cidades = new List<string>();
            cidades.Add("São Paulo");
            cidades.Add("Rio de Janeiro");
            cidades.Add("Teste");

            List<int> numeros = new List<int>();
            numeros.Add(10);
            numeros.Add(3);

            foreach (string c in cidades)
            {
                Console.WriteLine(c);
            }

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
            */

            /*
            ArrayList lista = new ArrayList();
            lista.Add("São Paulo");
            lista.Add("Rio de Janeiro");
            lista.Add("Santos");
            lista.Add(10);


            string cidade = Convert.ToString(lista[1]);

            foreach (string cid in lista)
            {
                Console.WriteLine(cid);
            }

            lista.Remove("Santos");
            lista.Insert(0, "Londres");

            Console.WriteLine("------");
            foreach (string cid in lista)
            {
                Console.WriteLine(cid);
            }

            int tamanho = lista.Count;

            Console.WriteLine("Tamanho:{0}", tamanho);
            */


        }
    }
}
