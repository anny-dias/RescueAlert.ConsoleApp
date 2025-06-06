using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;
using RescueAlert.RepositoryLibrary.Repositories;

namespace RescueAlert.ControllerLibrary.Controllers
{
    public class PessoaController
    {
        private readonly PessoaRepository _repo = new PessoaRepository();

        public void CadastrarPessoa()
        {
            try
            {
                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Digite a idade:");
                if (!int.TryParse(Console.ReadLine(), out int idade))
                    throw new FormatException("Idade inválida.");

                Console.WriteLine("Digite o endereço:");
                string endereco = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Tipo: 1-Idoso | 2-Deficiente | 3-Pobreza");
                string tipo = Console.ReadLine();

                Pessoa novaPessoa;

                switch (tipo)
                {
                    case "1":
                        novaPessoa = new Idoso { Nome = nome, Idade = idade, Endereco = endereco };
                        break;
                    case "2":
                        novaPessoa = new Deficiente { Nome = nome, Idade = idade, Endereco = endereco };
                        break;
                    case "3":
                        novaPessoa = new PessoaEmPobreza { Nome = nome, Idade = idade, Endereco = endereco };
                        break;
                    default:
                        throw new ArgumentException("Tipo inválido");
                }

                _repo.Adicionar(novaPessoa);
                Console.WriteLine("Pessoa cadastrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao cadastrar pessoa: {ex.Message}");
            }
        }

        public List<Pessoa> ListarPessoas() => _repo.Listar();
    }
}