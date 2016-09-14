using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public class Telefone
    {
        public int Id { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }
        public TipoTelefone Tipo { get; set; }
    }

    public enum TipoTelefone
    {
        Fixo,
        Celular,
        Fax,
        Recado
    }
}
