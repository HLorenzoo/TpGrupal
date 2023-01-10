using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Camion :Terrestre
    {
        public Camion() { }

        public Camion(string marca, string matricula, float cargaMaxima) : base(marca, matricula)
        {
         CargaMaxima= cargaMaxima;
        }

        public float CargaMaxima { get; set; }
    }
}
