using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class BicicletaCarrera:Bici
    {
        public BicicletaCarrera() { }
        public BicicletaCarrera(string marca, string matricula, string tipo,int peso) : base(marca, matricula,tipo)
        {
           Peso= peso;  
        }
        public int Peso { get; set; }
    }
}
