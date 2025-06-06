using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RescueAlert.ModelLibrary.Models;


namespace RescueAlert.RepositoryLibrary.Repositories
{
    public class PessoaRepository
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();
        private static int contadorId = 1;

        public void Adicionar(Pessoa pessoa)
        {
            pessoa.Id = contadorId++;
            pessoas.Add(pessoa);
        }

        public List<Pessoa> Listar()
        {
            return pessoas.ToList();
        }

        public Pessoa ObterPorId(int id)
        {
            return pessoas.FirstOrDefault(p => p.Id == id);
        }
    }
}