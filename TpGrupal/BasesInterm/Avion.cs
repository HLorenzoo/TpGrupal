using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Avion : VehiculoAereo
    {
        public Avion() { }
        public Avion(string nombre, double peso):base(nombre,peso) { }
        public void Despegar() 
        {
        }
    }
}
