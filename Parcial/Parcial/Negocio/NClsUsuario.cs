using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Negocio
{
    class NClsUsuario
    {public string ACCESO(ClsUsuario usuario)
        {

            if (usuario.Nombre == "Marvin" || usuario.Contra == 123) 

            {

                return "Inicio de Sesion correcto puedes continuar con el proceso de venta:";
            }
            else
            {
                return "Nombre de usurio incorrecto";



            }
        }
    }
}
        
    
      
    

