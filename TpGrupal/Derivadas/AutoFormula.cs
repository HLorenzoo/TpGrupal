using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class AutoFormula:Auto
    {
        public AutoFormula() { }
        public AutoFormula (string marca, string matricula, int cantidadPasajeros,int velocidadMaxima) : base(marca, matricula,cantidadPasajeros)
        {
            VelocidadMaxima = velocidadMaxima;
        }
        public int VelocidadMaxima { get; set; }
    }
}
