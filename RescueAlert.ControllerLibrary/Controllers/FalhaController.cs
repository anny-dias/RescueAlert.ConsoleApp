using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;
using RescueAlert.RepositoryLibrary.Repositories;


namespace RescueAlert.ControllerLibrary.Controllers
{
    public class FalhaController
    {
        private readonly FalhaRepository _repo = new FalhaRepository();

        public void RegistrarFalha()
        {
            try
            {
                Console.WriteLine("Local da falha:");
                string local = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Descrição da falha:");
                string descricao = Console.ReadLine() ?? throw new ArgumentNullException();

                Console.WriteLine("Data da falha (dd/MM/yyyy):");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime data))
                    throw new FormatException("Data inválida.");

                var falha = new Falha
                {
                    DataOcorrencia = data,
                    Local = local,
                    Descricao = descricao
                };

                _repo.Adicionar(falha);
                Console.WriteLine("Falha registrada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao registrar falha: {ex.Message}");
            }
        }

        public List<Falha> ListarFalhas() => _repo.Listar();
    }
}
