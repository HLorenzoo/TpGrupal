using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Zeppelin:VehiculoAereo
    {
        public Zeppelin() { }
        public Zeppelin(string nombre, double peso,float combustibleMaximo) : base(nombre, peso) 
        {
            CombustibleMaximo   = combustibleMaximo;
        }
        public float CombustibleMaximo { get; set; }
    }
}
