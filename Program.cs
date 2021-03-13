using System;

namespace Matriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da sua matriz (linhas colunas): ");
            string[] valores = Console.ReadLine().Split(' ');
            int numLinhas = int.Parse(valores[0]);
            int numColunas = int.Parse(valores[1]);
            double[,] matriz = new double[numLinhas, numColunas];
            for (int a = 0; a < numLinhas; a++)
            {
                Console.Write("Digite a " + (a + 1) + "ª linha da matriz: ");
                string[] dadosLinha = Console.ReadLine().Split(' ');
                for (int b = 0; b < numColunas; b++)
                {
                    matriz[a, b] = double.Parse(dadosLinha[b]);
                }
            }
            Console.Write("Digite um número que tem na matriz: ");
            double numProcurado = double.Parse(Console.ReadLine());
            for (int c=0; c < numLinhas; c++)
            {
                for (int d=0; d<numColunas; d++)
                {
                    if (matriz[c,d] == numProcurado)
                    {
                        Console.WriteLine("Foi encontrado o número "+numProcurado+ " na " + (c + 1) + "ª linha  com a "+ (d + 1) + "ª coluna.");
                        if ((c - 1) >= 0)
                        {
                            Console.WriteLine("O número que está acima dele na matriz é o "+matriz[(c - 1),d]);
                        }
                        else { Console.WriteLine("Não há números acima dele na matriz."); }
                        if ((c + 1) < numLinhas)
                        {
                            Console.WriteLine("O número que está abaixo dele na matriz é o " + matriz[(c + 1), d]);
                        }
                        else { Console.WriteLine("Não há números abaixo dele na matriz."); }
                        if ((d - 1) >= 0)
                        {
                            Console.WriteLine("O número que está à esquerda dele na matriz é o " + matriz[c, (d - 1)]);
                        }
                        else { Console.WriteLine("Não há números à esquerda dele na matriz."); }
                        if ((d + 1) < numColunas)
                        {
                            Console.WriteLine("O número que está à direita dele na matriz é o " + matriz[c, (d + 1)]);
                        }
                        else { Console.WriteLine("Não há números à direita dele na matriz."); }
                    }
                }
            }
        }
    }
}
