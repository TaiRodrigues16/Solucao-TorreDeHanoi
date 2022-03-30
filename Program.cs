using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi_Trabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilha T01 = new Pilha();
            //Pilha T02 = new Pilha();
            //Pilha T03 = new Pilha();

            T01.Push(1);
            T01.Push(2);
            T01.Push(3);
            T01.Push(4);
            T01.Push(5);
            T01.Push(6);
            T01.Pop();
            T01.Pop();
            T01.Pop();
            T01.Pop();
            T01.Pop();

            T01.Imprimir();

            /* //T01.Imprimir();
             Console.WriteLine("---------------------");
             Console.WriteLine("Inicio");
             Console.WriteLine();
             Console.WriteLine("1º Torre: ");
             T01.Imprimir();
             Console.WriteLine();
             Console.WriteLine("2º Torre: ");
             T02.Imprimir();
             Console.WriteLine();
             Console.WriteLine("3º Torre: ");
             T03.Imprimir();
             Console.WriteLine();
             Console.WriteLine("---------------------");
             int num = 3;

             TorreDeHanoi(num, T01, T02, T03);
             Console.WriteLine();
             Console.WriteLine("Numero de movimentos: " + ((Math.Pow(2,num))-1));*/

        }

        /*public static void TorreDeHanoi(int num, Pilha t1, Pilha t2, Pilha t3)
        {
            if (num > 0)
            {
                TorreDeHanoi(num - 1, t1, t3, t2);
                t3.Push(t1.Pop());

                Console.WriteLine();
                Console.WriteLine("1º Torre: ");
                t1.Imprimir();
                Console.WriteLine();
                Console.WriteLine("2º Torre: ");
                t2.Imprimir();
                Console.WriteLine();
                Console.WriteLine("3º Torre: ");
                t3.Imprimir();
                Console.WriteLine();
                Console.WriteLine("---------------------");
                TorreDeHanoi(num-1, t2, t1, t3);

            }
        }*/
        
    }
}
