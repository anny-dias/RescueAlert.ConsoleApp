using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;


namespace RescueAlert.RepositoryLibrary.Repositories
{
    public class OperadorRepository
    {
        private readonly List<Operador> operadores = new List<Operador>()
        {
            new Operador { Usuario = "admin", Senha = "1234" }
        };

        public bool Autenticar(string usuario, string senha)
        {
            return operadores.Exists(op => op.Usuario == usuario && op.Senha == senha);
        }
    }
}