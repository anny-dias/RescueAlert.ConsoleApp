using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RescueAlert.ModelLibrary.Models
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Idade { get; set; }
        public string Endereco { get; set; } = string.Empty;

        public abstract string TipoVulnerabilidade { get; }

        public override string ToString()
        {
            return $"[{Id}] {Nome} - {TipoVulnerabilidade} - {Endereco}";
        }
    }
}

namespace RescueAlert.ModelLibrary.Models
{
    public class Idoso : Pessoa
    {
        public override string TipoVulnerabilidade => "Idoso";
    }

    public class Deficiente : Pessoa
    {
        public override string TipoVulnerabilidade => "Pessoa com Deficiência";
    }

    public class PessoaEmPobreza : Pessoa
    {
        public override string TipoVulnerabilidade => "Situação de Pobreza";
    }
}
