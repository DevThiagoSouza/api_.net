using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.Models
{
    public class Aluno
    {
        public Aluno() {}

        public Aluno(int id, string nome, string sobrenome, string telefone)
        {
            this.id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        public int id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        public IEnumerable<AlunoDiciplina> alunoDiciplinas { get; set; }
    }
}
