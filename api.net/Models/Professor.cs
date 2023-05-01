using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.net.Models
{
    public class Professor
    {
        public Professor() { }
        public Professor(int id, string nome)
        {
            this.id = id;
            Nome = nome;
        }

        public int id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Diciplina> diciplinas { get; set; }
    }
}
