//criar um programa que faça o cadastro de usuarios n vezes até que a opção de saida seja selecionada no menu.
//deve conter submenus para selecionar qual o tipo de atendimento
//deve utilizar dos conceitos do CRUD

using Training.Models;

List<Pessoa> listaPessoas = new List<Pessoa>();
var menu = new Menu();

/*
    
    TODO adicionar enum para realizar leitura e apresentação do tipo de setor
    
    considerar o uso de dictionary para armazenar o valor do tipo do setor

    Dictionary<int, string> setores = new Dictionary<int, string>();

    setores.Add(1 , "Atendimento")
    ...
    
*/


var continuarAtendimento = true;
do
{

    switch (menu.MenuInicial())
    {
        case "1":
            Console.Clear();
            Pessoa novaPessoa = new();
            switch (menu.Submenu())
            {
                case "1":
                    novaPessoa = Pessoa.RealizarCadastro(1);
                    break;
                case "2":
                    novaPessoa = Pessoa.RealizarCadastro(2);
                    break;
                case "3":
                    novaPessoa = Pessoa.RealizarCadastro(3);
                    break;
                case "4":
                    novaPessoa = Pessoa.RealizarCadastro(4);
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Insira uma opção válida.");
                    Console.ReadKey();
                    break;
            }
            listaPessoas.Add(novaPessoa);
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            Pessoa.ListarAtendimentos(listaPessoas);
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine($"Selecione o setor desejado");
            Console.WriteLine($"1 - Abertura de Conta");
            Console.WriteLine($"2 - Caixa");
            Console.WriteLine($"3 - Gerente Pessoa Física");
            Console.WriteLine($"4 - Gerente Pessoa Jurídica");
            Console.WriteLine($"5 - Voltar");

            bool validEntry = false;
            int setorSelecionado;
            do
            {
                validEntry = int.TryParse(Console.ReadLine(), out setorSelecionado);
            } while (!validEntry);

            if (setorSelecionado != 5)
            {
                Pessoa.ListarAtendimentosPorSetor(listaPessoas, setorSelecionado);
            }
            else
            {
                break;
            }

            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Tem certeza que deseja sair?");
            Console.WriteLine("Digite y para sim ou tecle qualquer outra tecla para recusar.");
            if (Console.ReadLine() is "y" or "Y")
            {
                continuarAtendimento = false;
            }
            Console.Clear();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Insira uma opção válida.");
            Console.ReadKey();
            break;
    }

} while (continuarAtendimento);






