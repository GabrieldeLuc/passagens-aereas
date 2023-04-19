static bool Login(string senha)
{
    if (senha == "123456")
    {
        return true;
    }
    else
    {
        Console.WriteLine($"Senha inválida, Tente Novamente: ");
        return false;
    }
}


string[] Nomes = new string[2];
string[] Origens = new string[2];
string[] Destinos = new string[2];
string[] Datas = new string[2];

bool senhaValida;

do
{
    Console.WriteLine($"Informe a Senha: ");
    string senha = Console.ReadLine()!;

    senhaValida = Login(senha);

} while (senhaValida != true);

string opcao;

do
{


    Console.WriteLine($"Menu de opções");

    Console.BackgroundColor = ConsoleColor.DarkBlue;
    
  Console.WriteLine(@$" 
----------------------------------------------------------
|Bem vindo ao Sistema, selecione uma das opções a seguir |
|                                                        |
| 1 - Cadastro de Passagens                              |
|                                                        |
| 2 - Listar Passagens                                   |
|                                                        |
| 0 - Sair do Sistema                                    |
|                                                        |
----------------------------------------------------------"); 
Console.ResetColor();


    opcao = Console.ReadLine()!;

    string resposta;

    switch (opcao)
    {
        case "1":
            do
            {
                for (var i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Informe seu Nome: ");
                    Nomes[i] = Console.ReadLine()!;

                    Console.WriteLine($"Informe a Origem: ");
                    Origens[i] = Console.ReadLine()!;

                    Console.WriteLine($"Informe seu Destino: ");
                    Destinos[i] = Console.ReadLine()!;

                    Console.WriteLine($"Informe a Data:  ");
                    Datas[i] = Console.ReadLine()!;
                }

                Console.WriteLine($"Quer cadastrar mais passagens? 's' para Sim e 'n' para Não");
                resposta = Console.ReadLine()!.ToLower();

            } while (resposta == "s");
            break;
        case "2":
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine(@$"
                *******************
                Passagens - Bilhete

                Nome: {Nomes[i]}
                Origem: {Origens[i]}
                Destino: {Destinos[i]}
                Data: {Datas[i]}
                ");
            }
            break;
        case "0":
            Console.WriteLine($"Obrigado por usar o Sistema, Até Mais!");
            break;
        default:
            Console.WriteLine($"Opção inválida!");
            break;
    }
} while (opcao != "0");