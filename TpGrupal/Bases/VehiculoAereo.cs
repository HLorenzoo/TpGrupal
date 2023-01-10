using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class VehiculoAereo
    {
        public VehiculoAereo() { }
        public VehiculoAereo(string nombre,double peso) { 
            Nombre= nombre;
            PesoVehiculo= peso;
        }

        public double PesoVehiculo;
        public string Nombre;

    }
}
