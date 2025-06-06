using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;

namespace RescueAlert.RepositoryLibrary.Repositories
{
    public class FalhaRepository
    {
        private static List<Falha> falhas = new List<Falha>();
        private static int contadorId = 1;

        public void Adicionar(Falha falha)
        {
            falha.Id = contadorId++;
            falhas.Add(falha);
        }

        public List<Falha> Listar()
        {
            return falhas.ToList();
        }

        public Falha ObterPorId(int id)
        {
            return falhas.FirstOrDefault(f => f.Id == id);
        }
    }
}