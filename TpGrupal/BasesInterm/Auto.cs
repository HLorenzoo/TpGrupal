using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Auto : Terrestre
    {
        public Auto() { }
        public Auto(string marca, string matricula,int cantidadPasajeros):base(marca,matricula) 
        {
            CantidadPasajeros= cantidadPasajeros;
        }
        public void Arrancar()
        {

        }
        public int CantidadPasajeros { get; set; }
    }
}
