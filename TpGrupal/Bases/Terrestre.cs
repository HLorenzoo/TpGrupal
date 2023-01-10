using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpGrupal
{
    public class Terrestre
    {
        public Terrestre() { }
        public Terrestre(string marca, string matricula)
        {
            Marca = marca;
            Matricula = matricula;
        }

        public string Matricula;
        public string Marca;

    }
}

