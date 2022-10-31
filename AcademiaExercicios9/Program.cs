namespace AcademiaExercicios9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            List<Pessoa> pessoas = new List<Pessoa>();
            int opc = 0;
            Pessoa p;
            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "nomes.csv";
            const string arq = caminho + nomeArq;
            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaPessoa(pessoas, arq);
            //exibir no inicio...            
            Util.mostrarListaPessoa(pessoas);
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de Nomes ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um Nome");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar Nomes");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual nome deseja cadastrar? ");
                        Console.ResetColor();
                        string nomeDigitado = Console.ReadLine().ToUpper();
                        string[] filtro = nomeDigitado.Split(" ");
                        if(filtro.Length > 1)
                        {
                            p = new Pessoa(nomeDigitado);
                            if (Util.jaNaListaPessoa(p, pessoas))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{nomeDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                pessoas.Add(p);
                                Util.gravarPessoaArquivo(p, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Favor inserir um nome completo.\n");
                            Console.ResetColor();
                            break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Util.mostrarListaPessoa(pessoas);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */



            /*
            List<Emails> emails = new List<Emails>();
            int opc = 0;
            Emails email;
            const string caminho = @"D:\Desenvolvimento\.NET\academiaDotNet_Atos\Exercicios_Lista9\";
            const string nomeArq = "emails.csv";
            const string arq = caminho + nomeArq;
            //popula a list com os dados já no arquivo...
            Util.popularArquivoNaListaEmail(emails, arq);
            //exibir no inicio...            
            Util.mostrarListaEmail(emails);
            //Console.WriteLine();
            do
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(" === Cadastro de E-mails ===\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("1 - Cadastrar um E-mail");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("2 - Listar E-mails");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("3 - Sair");
                Console.ResetColor();
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Qual e-mail deseja cadastrar? ");
                        Console.ResetColor();
                        string emailDigitado = Console.ReadLine();
                        string[] filtro = emailDigitado.Split("@");
                        if (filtro.Length > 1)
                        {
                            string usuario = filtro[0];
                            string dominio = filtro[1];
                            if (!dominio.Contains("."))
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Favor incluir um e-mail válido.\nÉ necessário possuir ao menos um domínio válido.\n");
                                Console.ResetColor();
                                break;
                            }
                            email = new Emails(emailDigitado, dominio);
                            if (Util.jaNaListaEmail(email, emails))
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"\n'{emailDigitado}' já está cadastrado!\nUtilize outro\n");
                                Console.ResetColor();
                            }
                            else
                            {
                                emails.Add(email);
                                Util.gravarEmailArquivo(email, arq);
                            }
                        } else
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Favor inclua um e-mail completo: 'nome'@'domínio'\n");
                            Console.ResetColor();
                        }
                        break;
                    case 2:
                        Console.Clear();                        
                        Util.mostrarListaEmail(emails);
                        break;
                    case 3: break;
                }
            } while (opc != 3);
            */

            

            List<Figurinha> listaRepetidas = new List<Figurinha>();
            List<Figurinha> listaFaltantes = new List<Figurinha>();
            int opcao;

            //conectar com a base de dados
            //Util.popularArquivoNaListaFigurinha(listaRepetidas, "repetidas.csv");
            //Util.popularArquivoNaListaFigurinha(listaFaltantes, "faltantes.csv");

            do
            {
                Console.WriteLine("1 - Cadastrar figurinha Repetida");
                Console.WriteLine("2 - Cadastrar figurinha Faltante");
                Console.WriteLine("3 - Listar figurinha Repetida");
                Console.WriteLine("4 - Listar figurinha Faltante");
                Console.WriteLine("5 - Sair");
                Console.Write("\nOpção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default: break;
                }
            } while (opcao != 5);

        }
    
    }
}