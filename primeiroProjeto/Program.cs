// Screen Sound
string msgBoasVindas = "Boas vindas ao screen Sound";



void ExibirMsgBoasVindas()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(msgBoasVindas);
   
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida =  Console.ReadLine()!;
    int opcaoEscolhidanumerica = int.Parse(opcaoEscolhida);
    // código omitido
    /*
    if (opcaoEscolhidanumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidanumerica == 2)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidanumerica == 3)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidanumerica == 4)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    else if (opcaoEscolhidanumerica == -1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
    */

    switch(opcaoEscolhidanumerica)
    {
        case 1: Console.WriteLine("Você digitou a opção " + opcaoEscolhidanumerica);
            break;
           
        case 2: Console.WriteLine("Você digitou a opção " + opcaoEscolhidanumerica);
            break;
            
        case 3: Console.WriteLine("Você digitou a opção " + opcaoEscolhidanumerica);
            break;
            
        case 4: Console.WriteLine("Você digitou a opção " + opcaoEscolhidanumerica);
            break;
            
        case -1: Console.WriteLine("Tchau Tchau ! ");
            break;
            
        default: Console.WriteLine("Opção Inválida");
            break;

    }

}

ExibirMsgBoasVindas();
ExibirOpcoesDoMenu();