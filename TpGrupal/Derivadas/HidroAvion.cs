using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class HidroAvion:Avion
    {
        public HidroAvion() { }
        public HidroAvion(string nombre, double peso, int capacidadAgua) : base(nombre, peso)
        {
            CapacidadAgua= capacidadAgua;
        }
        public int CapacidadAgua { get; set; }
    }
}
