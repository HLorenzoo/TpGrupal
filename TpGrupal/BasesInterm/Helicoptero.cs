using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Helicoptero : VehiculoAereo
    {
        public Helicoptero() { }
        public Helicoptero(string nombre, double peso,int alturaMax) : base(nombre, peso) 
        { 
            AlturaMax= alturaMax;
        }
       public int AlturaMax { get; set; }
    }
}
