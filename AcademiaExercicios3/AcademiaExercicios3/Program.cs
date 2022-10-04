using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net;

namespace AcademiaExercicios3
{
    internal class Program
    {
        /*Questao 01
        static void Main(string[] args)
        {
            int numero;

            do
            {
                Console.WriteLine("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Numero invalido. Vai precisar redigitar!");

                }
                else break;

            } while (true);

            Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                Console.Write(i + " ");
            }

        }*/

        /*Questao 02
        static void Main(string[] args)
        {
            int numero;
           
            do
            {

                Console.WriteLine("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Numero invalido. Vai precisar redigitar!");

                }
                else break;

            } while (true);

            Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n\n Deseja informar outro número (s/n)?");
            Console.ReadLine();

            Console.WriteLine("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());
            if (numero <= 0)
            {
                Console.WriteLine("Numero invalido. Vai precisar redigitar!");
            }
            Console.Write("\n\n os pares entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }

            Console.WriteLine("\n\n Deseja informar outro número (s/n)?");
            Console.ReadLine();





        }*/

        /*Questao 03
        static void Main(string[] args)
        {
            int numero;

            do
            {

                Console.WriteLine("Digite um numero inteiro: ");
                numero = int.Parse(Console.ReadLine());
                if (numero <= 0)
                {
                    Console.WriteLine("Numero invalido. Vai precisar redigitar!");

                }
                else break;

            } while (true);

            Console.Write("\n\n Os pares entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.Write("\n\n Os impares entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (i % 2 != 0)
                    Console.Write(i + " ");
            }

            Console.Write("\n\n Os primos entre 1 e " + numero + " sao: ");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    Console.Write(i + " ");
            }
        }*/

        //Questao 04
        //4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
        //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
        //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA.
        //Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário
        //escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
        //de votos em branco.
        static void Main(string[] args)
        {

        }
    }
   


}