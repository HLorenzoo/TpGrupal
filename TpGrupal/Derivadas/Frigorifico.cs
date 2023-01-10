using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Frigorifico:Camion
    {
        public Frigorifico() { }
        public Frigorifico(string marca, string matricula, float cargaMaxima, float cantAlimento) : base(marca, matricula, cargaMaxima)
        {
            CantAlimento = cantAlimento;         
        }
        public float CantAlimento { get; set; }
    }
}
