using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Moto : Terrestre
    {
        public Moto() { }

        public Moto(string marca, string matricula, int velocidadMaxima) : base(marca, matricula)
        {
            VelocidadMaxima= velocidadMaxima;
        }

        public int VelocidadMaxima { get; set; }
    }
}
