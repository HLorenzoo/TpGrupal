using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class CamionCarga:Camion
    {
        public CamionCarga() { }
        public CamionCarga(string marca, string matricula, float cargaMaxima,int cantRuedas) : base(marca, matricula,cargaMaxima)
        {
            CantRuedas = cantRuedas;
        }
        public int CantRuedas { get; set; }
    }
}
