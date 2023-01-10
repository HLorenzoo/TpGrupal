using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class HelicopteroGrua:Helicoptero
    {
        public HelicopteroGrua() { }
        public HelicopteroGrua(string nombre, double peso, int alturaMax,float pesoMaximo) : base(nombre, peso, alturaMax)
        {
            PesoMaximo = pesoMaximo;
        }
        public float PesoMaximo { get; set; }
    }
}
