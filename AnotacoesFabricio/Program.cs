namespace AnotacoesFabricio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] y = new int[10] { 1, 6, 30, 4, 5, 60, 7, 9, 10, 11 };
            int[] uniao = new int[20];
            int[] diferenca = new int[10];
            int[] interseccao = new int[10];
            Console.WriteLine("UNIÃO");
            x.CopyTo(uniao, 0);
            int auxU = 10;
            //                        0  1  2  3  4  5  6  7  8   9
            //int[] x = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] y = new int[10] { 1, 6,30, 4, 5,60, 7, 9,10, 11 };
            for (int i = 0; i < y.Length; i++)//elementos de x e elementos y que não estão em X
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }
                    if (j == (x.Length - 1))
                    {
                        uniao[auxU] = y[i];
                        auxU++;
                    }
                }
            }
            for (int i = 0; i < auxU; i++)
            {
                Console.WriteLine(uniao[i]);
            }
            Console.WriteLine("");

            int[,] matriz = new int[3, 3];
            //preencher a matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição " + i + " - " + j + " da matriz:");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //mostrando o conteúdo da matríz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            //dobrar todos os valores de uma matriz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = matriz[i, j] * 2;
                }
            }
            Console.WriteLine();
            //mostrando o conteúdo da matríz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
            //diagonal principal
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (i == j)
            //        {
            //            matriz[i, j] = matriz[i, j] * 2;
            //        }
            //    }
            //}
            for (int i = 0; i < 3; i++)
            {
                matriz[i, i] = matriz[i, i] * 2;
            }
            Console.WriteLine();
            //mostrando o conteúdo da matríz
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[" + i + "," + j + "] = " + matriz[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}