using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ControllerLibrary.Controllers;
using System.IO;

namespace RescueAlert.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            LoginController loginController = new LoginController();
            if (!loginController.FazerLogin())
            {
                Console.WriteLine("Encerrando aplicação.");
                return;
            }

            PessoaController pessoaController = new PessoaController();
            FalhaController falhaController = new FalhaController();
            AlertaController alertaController = new AlertaController();

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("\n===== MENU PRINCIPAL =====");
                Console.WriteLine("1 - Cadastrar Pessoa Vulnerável");
                Console.WriteLine("2 - Registrar Falha de Energia");
                Console.WriteLine("3 - Gerar Alerta");
                Console.WriteLine("4 - Listar Pessoas");
                Console.WriteLine("5 - Listar Falhas");
                Console.WriteLine("6 - Gerar Relatório de Alertas");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.Clear();

                try
                {
                    switch (opcao)
                    {
                        case "1":
                            pessoaController.CadastrarPessoa();
                            RegistrarLog("Pessoa cadastrada.");
                            break;

                        case "2":
                            falhaController.RegistrarFalha();
                            RegistrarLog("Falha registrada.");
                            break;

                        case "3":
                            alertaController.GerarAlerta();
                            RegistrarLog("Alerta gerado.");
                            break;

                        case "4":
                            var pessoas = pessoaController.ListarPessoas();
                            Console.WriteLine("=== Pessoas Cadastradas ===");
                            pessoas.ForEach(p => Console.WriteLine(p));
                            break;

                        case "5":
                            var falhas = falhaController.ListarFalhas();
                            Console.WriteLine("=== Falhas Registradas ===");
                            falhas.ForEach(f => Console.WriteLine(f));
                            break;

                        case "6":
                            alertaController.GerarRelatorio();
                            break;

                        case "0":
                            continuar = false;
                            Console.WriteLine("Encerrando...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro inesperado: {ex.Message}");
                    RegistrarLog($"Erro: {ex.Message}");
                }
            }
        }

        static void RegistrarLog(string mensagem)
        {
            string caminho = "log_eventos.txt";
            string texto = $"[{DateTime.Now}] {mensagem}{Environment.NewLine}";
            File.AppendAllText(caminho, texto);
        }
    }
}