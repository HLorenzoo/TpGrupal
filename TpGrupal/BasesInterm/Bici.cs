using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Bici:Terrestre
    {
      public Bici() { }
     
      public Bici(string marca, string matricula,string tipo) : base(marca, matricula)
        {
            Tipo = tipo;
        }

        public string Tipo { get; set; }
    }
}
