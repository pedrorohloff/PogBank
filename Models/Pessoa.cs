using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using Enum_1;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Runtime.InteropServices;


namespace SistemaBancario.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private SetorAtendimento Setor { get; set; }

        public void Cadastro()
        {
            Console.Clear();
            Console.WriteLine("Em qual setor deseja reservar o atendimento?");
            Console.WriteLine("1 - Abertura de Conta");
            Console.WriteLine("2 - Caixa");
            Console.WriteLine("3 - Gerente Pessoa Física");
            Console.WriteLine("4 - Gerente Pessoa Jurídica");

            Enum.TryParse(Console.ReadLine(), out SetorAtendimento setorSelecionado);

            Setor = setorSelecionado;
            
            Console.WriteLine("Digite seu nome: ");     
            Nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            Cpf = Console.ReadLine();
            Console.Clear();
        }
        // static void Descricao()
        // {
        //     Dictionary<SetorAtendimento, string> dicionarioSetorAtendimento = new Dictionary<SetorAtendimento, string>();
        //     dicionarioSetorAtendimento[SetorAtendimento.AberturaDeConta] = "Tipo Atendimento - 1 - Abertura de Conta\n===============================";
        //     dicionarioSetorAtendimento[SetorAtendimento.Caixa] = "Tipo Atendimento - 2 - Caixa\n===============================";
        //     dicionarioSetorAtendimento[SetorAtendimento.GerentePessoaFisica] = "Tipo Atendimento - 3 - Gerente Pessoa Física\n===============================";
        //     dicionarioSetorAtendimento[SetorAtendimento.GerentePessoaJuridica] = "Tipo Atendimento - 4 - Gerente Pessoa Jurídica\n===============================";
        // }

        public override string ToString()
        {
            
            string descricaoSetor = Descricao(Setor);

            return "Nome: " + Nome + "\nCPF: " + Cpf + "\nSetor: " + descricaoSetor;
        }
         private string Descricao(SetorAtendimento setor)
        {
            Dictionary<SetorAtendimento, string> dicionarioSetorAtendimento = new Dictionary<SetorAtendimento, string>
            {
                {SetorAtendimento.AberturaDeConta, "Tipo Atendimento - 1 - Abertura de Conta\n==============================="},
                {SetorAtendimento.Caixa, "Tipo Atendimento - 2 - Caixa\n==============================="},
                {SetorAtendimento.GerentePessoaFisica, "Tipo Atendimento - 3 - Gerente Pessoa Física\n==============================="},
                {SetorAtendimento.GerentePessoaJuridica, "Tipo Atendimento - 4 - Gerente Pessoa Jurídica\n==============================="},
            };

            // Verificar se o enum fornecido está no dicionário
            if (dicionarioSetorAtendimento.ContainsKey(setor))
            {
                // Retornar a descrição correspondente
                return dicionarioSetorAtendimento[setor];
            }

            // Se o enum não estiver no dicionário, retornar uma mensagem de erro
            return "Setor não encontrado.";
        }

        public string GetNome() => Nome;
        public string GetCpf() => Cpf;
        public SetorAtendimento GetSetor() => Setor;


    }
}