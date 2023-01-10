using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class BicicletaMtb:Bici
    {
        public BicicletaMtb() { }
        public BicicletaMtb(string marca, string matricula, string tipo, string suspension) : base(marca, matricula, tipo)
        {
            Suspension= suspension; 
        }
        public string Suspension { get; set; }
    }
}
