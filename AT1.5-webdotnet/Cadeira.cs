using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._5_webdotnet
{
    internal class Cadeira
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Professor> Professores { get; set; }
    }
}
