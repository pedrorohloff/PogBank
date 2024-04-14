namespace Training.Models
{
    public class Menu
    {
        public string MenuInicial()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("Bem vindo ao Sistema de Atendimento do PogBank!");
            Console.WriteLine("Por favor, selecione uma das opções para continuar o atendimento");
            Console.WriteLine("================================================================");
            Console.WriteLine("1 - Solicitar Atendimento");
            Console.WriteLine("2 - Listar Atendimentos Registrados");
            Console.WriteLine("3 - Listar Atendimentos por Setor");
            Console.WriteLine("4 - Sair");
            string opcao = "";
            string? readResult;
            bool validEntry = false;
            readResult = Console.ReadLine();
            do
            {
                if (readResult != null)
                {
                    opcao = readResult;
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Por favor, selecione uma das opções para continuar o atendimento");
                }
            } while (!validEntry);


            return opcao;
        }

        public string Submenu()
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("Bem vindo ao Sistema de Atendimento do PogBank!");
            Console.WriteLine("Por favor, selecione uma das opções para continuar o atendimento");
            Console.WriteLine("================================================================");
            Console.WriteLine("1 - Abertura de Conta");
            Console.WriteLine("2 - Caixa");
            Console.WriteLine("3 - Gerente Pessoa Física");
            Console.WriteLine("4 - Gerente Pessoa jurídica");
            Console.WriteLine("5 - Voltar");
            string opcao = "";
            string? readResult;
            bool validEntry = false;
            readResult = Console.ReadLine();
            do
            {
                if (readResult != null)
                {
                    opcao = readResult;
                    validEntry = true;
                }
                else
                {
                    Console.WriteLine("Por favor, selecione uma das opções para continuar o atendimento");
                }
            } while (!validEntry);

            return opcao;
        }
    }
}