using System.Threading.Channels;
using Enum_1;
using SistemaBancario;
using SistemaBancario.Models;
using System.Linq;

List<Pessoa> clientes = new List<Pessoa>();

var opcao = 0;
var saida = false;

do
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao sistema de atendimento PogBank!");
    Console.WriteLine("Selecione sua opção de atendimento:");
    Console.WriteLine("1 - Solicitar Atendimento");
    Console.WriteLine("2 - Listar Atendimentos Registrados");
    Console.WriteLine("3 - Listar Atendimento por Setor");
    Console.WriteLine("4 - Sair");
    var sucesso = int.TryParse(Console.ReadLine(), out opcao);

    if (!sucesso)
    {
        Console.WriteLine("Por favor digite uma opção válida.");
        Console.ReadKey();
        Console.Clear();
    }
    else
    {
        switch (opcao)
        {
            case 1:
                Pessoa novoCliente = new Pessoa();
                novoCliente.Cadastro();
                clientes.Add(novoCliente);
                Console.WriteLine("Cadastro realizado com sucesso!");
                break;
            case 2:
                Console.Clear();
                foreach (var cliente in clientes)
                {
                    Console.WriteLine(cliente.ToString());
                }

                Console.ReadKey();
                break;
            case 3:
                //implementar funcao listar antendimentos setor
                //Pessoa query = from setor in SetorAtendimento where setor == Console.ReadLine();

                break;
            case 4:
                //implementar saida
                saida = true;
                break;
        }
    }



} while (!saida);















