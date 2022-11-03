namespace CathTry
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    int x;
            //    Console.WriteLine("Informe um valor para X:");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("O valor de X é " + x);
            //    Console.WriteLine("O valor 50 dividido por " + x + " resulta em " + (50 / x));
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Não é possível dividir por zero.");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Apenas números devem ser digitados!");
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine("Numero informado invalido: muito grande");
            //}  
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally//opcional 
            //{
            //    //fechar conexão com o banco
            //    Console.WriteLine("Sempre executa, dando tudo certo ou nao!");
            //}

            ////escrita de arquivos
            ////StreamWriter writer = new StreamWriter(@"C:\Ursers\fabri\Desktop\atosUfm.txt"); (@)
            ////StreamWriter writer = new StreamWriter("C:\\Ursers\\fabri\\dDesktop\\atosUfm.txt"); (\)
            //StreamWriter writer = new StreamWriter(@"C:\Users\jonat\Desktop\atosUfm.txt");

            //writer.WriteLine("Hoje e segunda-feira!");
            //writer.WriteLine("Aula Atos-UFN");
            //writer.WriteLine();
            //writer.WriteLine();
            //writer.WriteLine("17-10-2022");

            //writer.Close();

            ////Nome, Idade, Sexo, Email, Telefone, Estado Civil, Casa Propria ou nao, valor alugel

            ////Gerar um arquivo, utilizando o ; como caractere delimitador para cada uma dessas informacaoes

            ////todas as informacoes, ficam na mesma linha - cada linha e uma pessoa

            //// apenas nome, idade e casa propria sao campos obrigatorios

            ////Exemplo
            ////Fabricio;21;;;;;;sim;0

            //Console.WriteLine("Informe o nome");
            //string nome = Console.ReadLine();

            //Console.WriteLine("Informe a idade");
            //int idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o sexo");
            //string sexo = Console.ReadLine();

            //Console.WriteLine("Informe o email");
            //string email = Console.ReadLine();

            //Console.WriteLine("Informe o fone");
            //string fone = Console.ReadLine();

            //Console.WriteLine("Informe o estado civil");
            //string estado = Console.ReadLine();

            //Console.WriteLine("Tem casa propria? (1 = SIM, 2 = NÃO");
            //int casa = int.Parse(Console.ReadLine());
            //double aluguel = 0;
            //if (casa == 2)
            //{
            //    Console.WriteLine("Informe o aluguel");
            //    aluguel = double.Parse(Console.ReadLine());
            //}
            //StreamWriter writer = new StreamWriter(@"C:\Users\jonat\Desktop\exemplo1.txt");
            ////Nome, idade, sexo, email, telefone, estado civil, casa propria ou não, valor aluguel

            //writer.Write(nome);
            //writer.Write(";");
            //writer.Write(idade);
            //writer.Write(";");
            //writer.Write(sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel + Environment.NewLine);


            //StreamReader reader = new StreamReader(@"C:\Users\jonat\Desktop\atosUfn.txt");

            //string linha = "xxxx";

            //Console.WriteLine("____________________________________________");

            //linha = reader.ReadLine();

            //while (linha != null)
            //{
            //    Console.WriteLine(linha);
            //    linha=reader.ReadLine();
            //}

            //Console.WriteLine("____________________________________________");
            //reader.Close();

            //exemplo 2
            
            Console.WriteLine("Informe o nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Informe a idade");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o sexo");
            string sexo = Console.ReadLine();
            
            Console.WriteLine("Informe o email");
            string email = Console.ReadLine();
            
            Console.WriteLine("Informe o fone");
            string fone = Console.ReadLine();
            
            Console.WriteLine("Informe o estado civil");
            string estado = Console.ReadLine();
            
            Console.WriteLine("Tem casa propria? (1 = SIM, 2 = NÃO");
            int casa = int.Parse(Console.ReadLine());
            double aluguel = 0;
            if (casa == 2)
            {
                Console.WriteLine("Informe o aluguel");
                aluguel = double.Parse(Console.ReadLine());
            }
            List<string> linhas = new List<string>();
            if (File.Exists(@"C:\Users\fabri\Desktop\exemplo2.txt"))
            {
                StreamReader reader = new StreamReader(@"C:\Users\fabri\Desktop\exemplo2.txt");
                linhas.Add(reader.ReadLine());
                string linha = "";
                while (linha != null)
                {
                    linha = reader.ReadLine();
                    if (linha != null)
                        linhas.Add(linha);
                }
                reader.Close();
            }
            linhas.Add(nome + ";" + idade + ";" + sexo + ";" + email + ";" + fone + ";" + estado + ";" + (casa == 1 ? "SIM" : "NÃO") + ";" + aluguel);
            StreamWriter writer = new StreamWriter(@"C:\Users\fabri\Desktop\exemplo2.txt");
            foreach (string item in linhas)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
    }
}