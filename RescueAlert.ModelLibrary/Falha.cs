using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueAlert.ModelLibrary.Models
{
    public class Falha
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Local { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"[{Id}] {DataOcorrencia} - {Local}: {Descricao}";
        }
    }
}
