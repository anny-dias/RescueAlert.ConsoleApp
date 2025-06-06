using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;
using RescueAlert.RepositoryLibrary.Repositories;

namespace RescueAlert.ControllerLibrary.Controllers
{
    public class AlertaController
    {
        private readonly AlertaRepository _repo = new AlertaRepository();
        private readonly PessoaRepository _pessoaRepo = new PessoaRepository();
        private readonly FalhaRepository _falhaRepo = new FalhaRepository();

        public void GerarAlerta()
        {
            try
            {
                Console.WriteLine("ID da Pessoa:");
                if (!int.TryParse(Console.ReadLine(), out int idPessoa))
                    throw new FormatException("ID inválido.");

                var pessoa = _pessoaRepo.ObterPorId(idPessoa) ?? throw new Exception("Pessoa não encontrada.");

                Console.WriteLine("ID da Falha:");
                if (!int.TryParse(Console.ReadLine(), out int idFalha))
                    throw new FormatException("ID inválido.");

                var falha = _falhaRepo.ObterPorId(idFalha) ?? throw new Exception("Falha não encontrada.");

                var alerta = new Alerta
                {
                    Pessoa = pessoa,
                    FalhaRelacionada = falha,
                    Status = "Pendente"
                };

                _repo.Adicionar(alerta);
                Console.WriteLine("Alerta gerado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao gerar alerta: {ex.Message}");
            }
        }

        public void GerarRelatorio()
        {
            var alertas = _repo.Listar();

            Console.WriteLine("=== RELATÓRIO DE ALERTAS ===");
            foreach (var alerta in alertas)
            {
                Console.WriteLine(alerta);
            }

            Console.WriteLine($"\nTotal de alertas: {alertas.Count}");
        }
    }
}