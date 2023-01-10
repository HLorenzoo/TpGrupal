using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class AutoUrbano:Auto
    {
        public AutoUrbano() { }
        public AutoUrbano(string marca, string matricula, int cantidadPasajeros,int cantidadPuertas) : base(marca, matricula,cantidadPasajeros)
        {
            CantidadPuertas= cantidadPuertas;
        }
        public int CantidadPuertas { get; set; }
    }
}
