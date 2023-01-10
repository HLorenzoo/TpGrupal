using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class HelicopteroMilitar:Helicoptero
    {
        public HelicopteroMilitar() { }
        public HelicopteroMilitar(string nombre, double peso, int alturaMax, float cantArmamento) : base(nombre, peso, alturaMax)
        {
            CantArmamento= cantArmamento;
        }
        public float CantArmamento { get; set; }
    }
}
