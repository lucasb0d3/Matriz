using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool achou = false;
            int linha = 20, colunas = 20, temp;
            int[,] Matriz_A = new int[linha, colunas];
            Random r = new Random();
            Console.WriteLine("EXERCICIOS");

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    temp = r.Next(1, 500);
                    Matriz_A[i, j] = temp;

                    if (achou == false)
                    {
                        foreach (int Numero in Matriz_A)
                        {
                            if (Numero == temp)
                            {
                                achou = true;

                            }
                        }
                    }


                  /*  if (achou == true)
                        Matriz_A[i, j] = temp;*/



                }
            }

            Console.WriteLine("+++ Matriz preencida +++++");

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.WriteLine($"O VALOR DA {i + 1}° linha e {j + 1}° coluna: " + Matriz_A[i, j]);
                }
            }

            Console.WriteLine("DIGITE O NUMERO QUE DESEJA BUSCAR NA MATRIZ: ");
            int NumeroDigitado = Convert.ToInt32(Console.ReadLine());
            int indColuna = 0;
            int indLinha = 0;


            for (int i = 0; i < linha; i++)
            {
                for (int j = colunas; j < linha;)
                {
                    if (NumeroDigitado == Matriz_A[i, j])
                        indColuna = j + 1;
                    indLinha = i + 1;



                }

            }



            if (indLinha == 0)
                Console.WriteLine($"O valor {NumeroDigitado} não esta na matriz");
            else
                Console.WriteLine($"O VALOR ENCONTRADO {NumeroDigitado} ÉSTA NA COLUNA  {indColuna}° E NA LINHA{indLinha}°:");

            Console.ReadKey();

        }

    

        
    }
}
