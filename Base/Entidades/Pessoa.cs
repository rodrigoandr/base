using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public List<Telefone> Telefones { get; set; }

        public Pessoa()
        {
            Telefones = new List<Telefone>();
        }
    }
}
