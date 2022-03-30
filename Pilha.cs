using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi_Trabalho
{
    class Pilha
    {
        /// <summary>
        /// Aponta para o topo da pilha
        /// </summary>
        public NoPilha Topo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public Pilha()
        {
            Topo = null;
        }

        /// <summary>
        /// Empilha o valor informado
        /// </summary>
        /// <param name="valor">Valor a ser empilhado</param>
        public void Push(int valor)
        {
            NoPilha novo = new NoPilha(valor);
            novo.Proximo = Topo;
            Topo = novo;
        }

        public int Pop()
        {
            int valorRetorno = -1;

            if (Topo != null)
            {
                valorRetorno = Topo.Info;
                Topo = Topo.Proximo;
            }

            return valorRetorno;
        }

        public void Imprimir()
        {
            if (Topo != null)
            {
                // Garantir que o Primeiro não perca a referência
                NoPilha navegador = Topo;

                while (navegador != null)
                {
                    Console.Write(navegador.Info + ", ");
                    navegador = navegador.Proximo;
                }
            }
        }
    }
}
