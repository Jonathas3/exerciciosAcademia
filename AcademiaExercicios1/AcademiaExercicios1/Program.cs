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

        ////QUESTAO 05
        //static void Main(string[] args)
        //{
        //    float KM = 0;
        //    float L = 0;

        //    Console.WriteLine("Informe a distacia percorrida em Km");
        //    KM = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a quantidade de combustivel disponivel");
        //    L = float.Parse(Console.ReadLine());

        //    float media;
        //    media = (KM + L) / 2;

        //    Console.WriteLine("Resultado: " + media);

        //    Console.ReadKey();

        //}

        ////QUESTAO 06
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Informe o código do parafuso A");
        //    int codA = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a quantidade de parafusos A");
        //    int quantA = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o valor do parafuso A");
        //    double valorA = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o código do parafuso B");
        //    int codB = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe a quantidade de parafusos B");
        //    int quantB = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o valor do parafuso B");
        //    double valorB = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o percentual do IPI");
        //    double ipi = double.Parse(Console.ReadLine());

        //    double totalA, totalB;

        //    totalA = (quantA * valorA);
        //    totalA = totalA + (totalA * (ipi / 100));

        //    totalB = quantB * valorB;
        //    totalB = totalB + (totalB * (ipi / 100));

        //    Console.WriteLine("Custo total dos parafusos A:" + totalA);
        //    Console.WriteLine("Custo total dos parafusos B:" + totalB);
        //}



        ////QUESTAO 07
        //static void Main(string[] args)
        //{
        //    int numeroVendedor;
        //    float salario_fixo, total_vendas;
        //    float comissao;

        //    Console.WriteLine("Numero do vendedor");
        //    numeroVendedor = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Salario Fixo....: R$");
        //    salario_fixo = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Total de Vendas.: R$");
        //    total_vendas = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite o valor da comissao em %:");
        //    comissao = int.Parse(Console.ReadLine());

        //    salario_fixo = salario_fixo + (total_vendas * (comissao / 100));

        //    Console.WriteLine("O numero do vendedor e:" + numeroVendedor);
        //    Console.WriteLine("Comissao: R$" + salario_fixo);


        //}

        ////QUESTAO 08
        //static void Main(string[] args)
        //{
        //    float c, f, conversao;

        //    Console.WriteLine("Digite a Temperatura em graus Fahrenheit:\n");
        //    f = float.Parse(Console.ReadLine());

        //    Console.WriteLine("Digite a Temperatura em graus Celsius");
        //    c = float.Parse(Console.ReadLine());

        //    conversao = (f = (9 * +160) / 5);

        //    Console.WriteLine("O valor da conversao foi de:\n" + conversao);


        //}

        ////QUESTAO 09 (resolucao do professor)
        //static void Main(string[] args)
        //{
        //    //3 prestações - 1+2x
        //    Console.WriteLine("Informe o valor da mercadoria");
        //    double mercadoria = double.Parse(Console.ReadLine());

        //    double prestacao = 0;

        //    double resto = mercadoria % 3;
        //    mercadoria = mercadoria - resto;

        //    prestacao = mercadoria / 3;

        //    double entrada = prestacao + resto;

        //    Console.WriteLine("entrade de " + entrada + " e 2x de " + prestacao);
        //}

        ////QUESTAO 09
        //static void Main(string[] args)
        //{
        //    float prest1, prest2, ValorM, ValorEnt;

        //    Console.WriteLine("Informe o valor da Mercadoria:");
        //    ValorM = float.Parse(Console.ReadLine());

        //    prest1 = ValorM / 3;
        //    prest2 = prest1;
        //    ValorEnt = ValorM - (prest1 + prest2);

        //    Console.WriteLine("O valor da primeira prestcao e:\n" + prest1);
        //    Console.WriteLine("O valor da segunda prestacao e:\n" + ValorEnt.ToString() + prest1.ToString() + prest2.ToString());
        //}


        ////QUESTAO 10
        //static void Main(string[] args)
        //{
        //    double saque = 0;
        //    int total100 = 0, total50 = 0, total20 = 0, total10 = 0, total5 = 0, total2 = 0, total1 = 0;

        //    Console.WriteLine("Informar o valor do saque:");
        //    saque = double.Parse(Console.ReadLine());
        //    total100 = (int)(saque / 100);

        //    Console.WriteLine("Notas de 100: " + total100);
        //    saque = saque - (100 * total100);
        //    total50 = (int)(saque / 50);

        //    Console.WriteLine("Notas de 50: " + total50);
        //    saque = saque - (50 * total50);
        //    total20 = (int)(saque / 20);

        //    Console.WriteLine("Notas de 20: " + total20);
        //    saque = saque - (20 * total20);
        //    total10 = (int)(saque / 10);

        //    Console.WriteLine("Notas de 10: " + total10);
        //    saque = saque - (10 * total10);
        //    total5 = (int)(saque / 5);

        //    Console.WriteLine("Notas de 5: " + total5);
        //    saque = saque - (5 * total5);
        //    total2 = (int)(saque / 2);

        //    Console.WriteLine("Notas de 2: " + total2);
        //    saque = saque - (2 * total2);
        //    total1 = (int)(saque / 1);

        //    Console.WriteLine("Notas de 1: " + total1);
        //    saque = saque - (1 * total1);
        //}

        ////QUESTAO 11
        //static void Main(string[] args)
        //{
        //    int eleitores, brancos, nulos, validos;
        //    float percBrancos, percNulos, percValidos;

        //    Console.WriteLine("|                                         |");
        //    Console.WriteLine("|              Eleições 2022              |");
        //    Console.WriteLine("|                                         |");

        //    Console.WriteLine("Informe o eleitorado:\n");
        //    eleitores = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o numero de votos validos:\n");
        //    validos = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o numero de votos brancos\n");
        //    brancos = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Informe o numero de votos nulos\n");
        //    nulos = int.Parse(Console.ReadLine());

        //    percValidos = (validos / eleitores) * 100;
        //    percBrancos = (brancos / eleitores) * 100;
        //    percNulos = (nulos / eleitores) * 100;

        //    Console.WriteLine(validos + " % de votos validos. " + percValidos);
        //    Console.WriteLine(brancos + " % de votos brancos. " + percBrancos);
        //    Console.WriteLine(nulos + " % de votos nulos. " + percNulos);

        //}

        ////QUESTAO 12
        //static void Main(string[] args)
        //{
        //    double valorRecebido, combustivelGasto, totalkm, marcadorfinaldia, marcadoriniciodia, mediaConsumo, lucrodia;

        //    Console.WriteLine("Qual a marcacao no inicio do dia?\n");
        //    marcadoriniciodia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantosa quilometros rodados no dia?\n");
        //    totalkm = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Quantidade de Litros gastos no dia\n");
        //    combustivelGasto = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual foi o lucro total recebido?\n");
        //    lucrodia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual foi o valor recebido?\n");
        //    valorRecebido = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Marcador no final do dia?\n");
        //    marcadorfinaldia = double.Parse(Console.ReadLine());

        //    Console.WriteLine("Qual a media de consumo?\n");
        //    mediaConsumo = double.Parse(Console.ReadLine());

        //    totalkm = marcadorfinaldia - marcadoriniciodia;
        //    mediaConsumo = totalkm / combustivelGasto;
        //    lucrodia = valorRecebido - (combustivelGasto * 6.98);

        //    Console.WriteLine(totalkm + "<-- Foi a quilometragem total!\n");
        //    Console.WriteLine(mediaConsumo + "<-- Foi a media de consume total!\n");
        //    Console.WriteLine(lucrodia + "<-- Foi o lucro do dia!\n");
        //}

        ////QUESTAO 13
        //static void Main(string[] args)
        //{
        //    double salarioMin = 0;
        //    double comissao = 0, custo = 0;
        //    int quantidade = 0;
            
        //    Console.WriteLine("Informe o salário mínimo atual:");
        //    salarioMin = double.Parse(Console.ReadLine());
            
        //    Console.WriteLine("Informe o preço de custo da bike:");
        //    custo = double.Parse(Console.ReadLine());
            
        //    Console.WriteLine("Informe a quantidade de bikes vendidas:");
        //    quantidade = int.Parse(Console.ReadLine());
            
        //    double venda = custo + (custo * 0.5);
        //    comissao = (quantidade * venda) * 0.15;
        //    double salario = (salarioMin * 2) + comissao;
            
        //    Console.WriteLine("O salário resultou em: " + salario);
        //}









    }
}