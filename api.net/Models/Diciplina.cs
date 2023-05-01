using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.Models
{
    public class Diciplina
    {
        public Diciplina() {}

        public Diciplina(int id, string nome, int professorId)
        {
            this.id = id;
            Nome = nome;
            ProfessorId = professorId;
        }

        public int id { get; set; }
        public string Nome { get; set; }
        public int ProfessorId { get; set; }

        public Professor professor { get; set; }

        public IEnumerable<AlunoDiciplina> alunoDiciplinas { get; set; }
    }
}
