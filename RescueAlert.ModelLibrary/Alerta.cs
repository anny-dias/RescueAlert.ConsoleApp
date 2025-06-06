using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueAlert.ModelLibrary.Models
{
    public class Alerta
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Falha FalhaRelacionada { get; set; }
        public string Status { get; set; } = "Pendente";

        public override string ToString()
        {
            return $"[{Id}] Alerta para {Pessoa.Nome} - Status: {Status}";
        }
    }
}
