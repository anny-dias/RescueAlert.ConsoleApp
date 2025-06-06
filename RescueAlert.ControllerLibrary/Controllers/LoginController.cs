using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.RepositoryLibrary.Repositories;



namespace RescueAlert.ControllerLibrary.Controllers
{
    public class LoginController
    {
        private readonly OperadorRepository _repo = new OperadorRepository();

        public bool FazerLogin()
        {
            Console.WriteLine("Usuário:");
            string usuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            string senha = Console.ReadLine();

            if (_repo.Autenticar(usuario, senha))
            {
                Console.WriteLine("Login realizado com sucesso.");
                return true;
            }

            Console.WriteLine("Credenciais inválidas.");
            return false;
        }
    }
}