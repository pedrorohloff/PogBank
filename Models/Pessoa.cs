namespace Training.Models
{
    public class Pessoa : Menu
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public int Setor { get; set; }

        public Pessoa(int id, string? nome, string? cpf, int setor)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Setor = setor;
        }

        public Pessoa()
        {
        }

        public static void ListarAtendimentos(List<Pessoa> lista)
        {
            Dictionary<int, string> setores = new Dictionary<int, string>()
            {

                {1, "1 - Abertura de Conta"},
                {2 ,"2 - Caixa"},
                {3 ,"3 - Gerente Pessoa Física"},
                {4 ,"4 - Gerente Pessoa Jurídica"},

            };

            foreach (var pessoa in lista)
            {
                Console.WriteLine($"ID: {pessoa.Id}");
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"CPF: {pessoa.Cpf}");
                if (pessoa.Setor == 1)
                {
                    Console.WriteLine($"Setor: {setores[1]}");
                }
                else if (pessoa.Setor == 2)
                {
                    Console.WriteLine($"Setor: {setores[2]}");
                }
                else if (pessoa.Setor == 3)
                {
                    Console.WriteLine($"Setor: {setores[3]}");
                }
                else if (pessoa.Setor == 4)
                {
                    Console.WriteLine($"Setor: {setores[4]}");
                }
                Console.WriteLine();
            }
        }

        public static void ListarAtendimentosPorSetor(List<Pessoa> listaPessoas, int setorSelecionado)
        {
            Dictionary<int, string> setores = new Dictionary<int, string>()
            {

                {1, "1 - Abertura de Conta"},
                {2 ,"2 - Caixa"},
                {3 ,"3 - Gerente Pessoa Física"},
                {4 ,"4 - Gerente Pessoa Jurídica"},

            };
            Console.WriteLine($"Atendimentos do setor {setorSelecionado}");
            foreach (var pessoa in listaPessoas)
            {
                if (pessoa.Setor == setorSelecionado)
                {
                    Console.WriteLine($"ID: {pessoa.Id}");
                    Console.WriteLine($"Nome: {pessoa.Nome}");
                    Console.WriteLine($"CPF: {pessoa.Cpf}");
                    if (pessoa.Setor == 1)
                    {
                        Console.WriteLine($"Setor: {setores[1]}");
                    }
                    else if (pessoa.Setor == 2)
                    {
                        Console.WriteLine($"Setor: {setores[2]}");
                    }
                    else if (pessoa.Setor == 3)
                    {
                        Console.WriteLine($"Setor: {setores[3]}");
                    }
                    else if (pessoa.Setor == 4)
                    {
                        Console.WriteLine($"Setor: {setores[4]}");
                    }
                    Console.WriteLine();
                }
            }
        }


        public static Pessoa RealizarCadastro(int setor)
        {
            Console.Clear();
            Pessoa novaPessoa = new();
            Random randomr = new Random();
            string? readResult;

            do
            {
                Console.Write("\nNome: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    novaPessoa.Nome = readResult;
                }
                else
                {
                    Console.WriteLine("Nome não pode estar vazio, por favor insira o nome.");
                }
            } while (string.IsNullOrEmpty(readResult));

            do
            {
                Console.Write("\nCPF: ");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    novaPessoa.Cpf = readResult;
                }
                else
                {
                    Console.WriteLine("CPF não pode estar vazio, por favor insira o CPF.");
                }

            } while (string.IsNullOrEmpty(readResult));

            novaPessoa.Setor = setor;
            novaPessoa.Id = randomr.Next(1000000, 9999999);
            Console.Clear();
            Console.WriteLine("Cadastro Realizado com sucesso!");
            Console.WriteLine($"Id do cadastro: {novaPessoa.Id}");

            return novaPessoa;
        }

    }
}