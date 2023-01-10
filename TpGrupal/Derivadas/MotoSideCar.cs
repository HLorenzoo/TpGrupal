using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class MotoSideCar:Moto

    {
        public MotoSideCar() { }
        public MotoSideCar(string marca, string matricula, int velocidadMaxima, int cantPasajeros) : base(marca, matricula, velocidadMaxima)
        {
            CantPasajeros = cantPasajeros;
        }
        public int CantPasajeros { get; set; }
    }
}
