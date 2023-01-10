using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class MotoCarrerra:Moto

    {
        public MotoCarrerra() { }
        public MotoCarrerra(string marca, string matricula, int velocidadMaxima, string motor) : base(marca, matricula, velocidadMaxima)
        {
            Motor= motor;
        }
        public string Motor { get; set; }
    }
}
