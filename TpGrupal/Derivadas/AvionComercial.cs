using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class AvionComercial:Avion
    {
        public AvionComercial() { }
        public AvionComercial(string nombre, double peso,int capacidad) : base(nombre, peso)
        {
            Capacidad= capacidad;   
        }
        public int Capacidad { get; set; }
    }
}