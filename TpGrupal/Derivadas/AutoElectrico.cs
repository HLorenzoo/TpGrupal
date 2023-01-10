using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class AutoElectrico:Auto
    {
        public AutoElectrico() { }
        public AutoElectrico(string marca, string matricula, int cantidadPasajeros,int nivelBateria) : base(marca, matricula,cantidadPasajeros)
        {
            NivelBateria= nivelBateria;
        }
        public int NivelBateria { get; set; }
    }
}
