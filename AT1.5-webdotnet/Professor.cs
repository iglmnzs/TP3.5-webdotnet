using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT1._5_webdotnet
{
    internal class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Cadeira> Cadeiras { get; set; }
    }
}
