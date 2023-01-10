using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Flete:Camion
    {
        public Flete() { }
        public Flete(string marca, string matricula, float cargaMaxima, int pesoMaximo) : base(marca, matricula, cargaMaxima)
        {
            PesoMaximo  = pesoMaximo;   
        }
        public int PesoMaximo { get; set; }
    }
}
