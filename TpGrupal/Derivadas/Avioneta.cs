using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Avioneta:Avion
    {
        public Avioneta() { }
        public Avioneta(string nombre, double peso, int cantPasajeros) : base(nombre, peso)
        {
            CantPasajeros= cantPasajeros;
        }
        public int CantPasajeros { get; set; }
    }
}
