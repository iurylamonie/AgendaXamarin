using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos.Models
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Fone { get; set; }
        public override string ToString()
        {
            return string.Format("Nome: {0} - Fone: {1}", Nome, Fone);
        }
    }
}
