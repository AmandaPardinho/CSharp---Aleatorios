using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes
{
    public class Program
    {
        public static int[] Adicionar(int[] arrayInicial, int value) 
        {
            int[] arrayTemporario = new int[arrayInicial.Length + 1];
            for (int i = 0; i < arrayInicial.Length; i++) 
            {
                arrayTemporario[i] = arrayInicial[i];
            }
            arrayTemporario[arrayInicial.Length] = value;
            return arrayTemporario;
        }
        static void Main(string[] args)
        {
            int[] arrayInicial = { 90, 70, 50, 80, 60, 85 };
            arrayInicial = Adicionar(arrayInicial, 75);
            for (int i = 0;i < arrayInicial.Length;i++)
            {
                Console.Write(arrayInicial[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
