using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class ClsUsuario
    {

        private string nombre;
        private int contra;

        public ClsUsuario()
        {
        }

        public ClsUsuario(string nombre, int contra)
        {
            this.nombre = nombre;
            this.contra = contra;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contra { get => contra; set => contra = value; }
    }
}
