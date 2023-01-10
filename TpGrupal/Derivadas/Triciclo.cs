using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Triciclo:Bici
    {
        public Triciclo() { }
        public Triciclo(string marca, string matricula, string tipo, int cantRuedas) : base(marca, matricula, tipo)
        {
            CantRuedas= cantRuedas; 
        }
        public int CantRuedas { get; set; }
    }
}
