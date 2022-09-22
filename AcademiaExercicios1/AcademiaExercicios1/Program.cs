namespace AcademiaExercicios1
{
    internal class Program
    {
        //QUESTAO 01
        //static void Main(string[] args)
        //{
        //    float n1 = 0;
        //    float n2 = 0;


        //    Console.WriteLine("Digite o numero 1");
        //    n1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o numero 2");
        //    n2 = float.Parse(Console.ReadLine());

        //    float media;
        //    media = (n1 + n2) / 2;

        //    Console.WriteLine("Resultado: " + media);

        //    Console.ReadKey();

        //QUESTAO 02
        //static void Main(string[] args)
        //{


        //    float n1 = 0;
        //    float n2 = 0;
        //    float n3 = 0;
        //    float n4 = 0;

        //    Console.WriteLine("Digite o numero 1");
        //    n1 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o numero 2");
        //    n2 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o numero 3");
        //    n3 = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o numero 4");
        //    n4 = float.Parse(Console.ReadLine());

        //    float media;
        //    media = (n1 + n2 + n3 + n4) / 4;

        //    Console.WriteLine("Resultado: " + media);

        //    Console.ReadKey();


        //}

        //QUESTAO 03
        //static void Main(string[] args)
        //{
        //    int A = 2;
        //    int B = 3;
        //    int Auxiliar;

        //    Auxiliar = A;
        //    A = B;
        //    B = Auxiliar;



        ////}
        //Questao 04
        //static void Main(string[] args)
        //{
        //    string dia;
        //    string mes;
        //    string ano;


        //    Console.WriteLine("Informe Dia");
        //    dia = Console.ReadLine();

        //    Console.WriteLine("Informe Mes");
        //    mes = Console.ReadLine();

        //    Console.WriteLine("Informe Ano");
        //    ano = Console.ReadLine();

        //    Console.WriteLine("Imprimindo.........>");
        //    Console.WriteLine("AAAAMMDD= "+ano +"/"+ mes +"/"+ dia);


        //    Console.WriteLine("AAMMDD= " + ano.Substring(2) + "/" + mes + "/" + dia);//funcao substring para mostrar a partir de posicao informada 012//

        //    Console.ReadKey();
        //}

        //QUESTAO 05
        static void Main(string[] args)
        {
            float KM = 0;
            float L = 0;

            Console.WriteLine("Informe a distacia percorrida em Km");
            KM = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de combustivel disponivel");
            L = float.Parse(Console.ReadLine());

            float media;
            media = (KM + L) / 2;

            Console.WriteLine("Resultado: " + media);

            Console.ReadKey();

        }

        //QUESTAO 06









    }
}