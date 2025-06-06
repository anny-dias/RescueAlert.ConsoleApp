using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;

namespace RescueAlert.RepositoryLibrary.Repositories
{
    public class AlertaRepository
    {
        private static List<Alerta> alertas = new List<Alerta>();
        private static int contadorId = 1;

        public void Adicionar(Alerta alerta)
        {
            alerta.Id = contadorId++;
            alertas.Add(alerta);
        }

        public List<Alerta> Listar()
        {
            return alertas.ToList();
        }

        public List<Alerta> FiltrarPorStatus(string status)
        {
            return alertas.Where(a => a.Status.Equals(status, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}