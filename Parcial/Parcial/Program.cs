using Parcial.Entidades;
using Parcial.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsUsuario usuario = new ClsUsuario();
            NClsUsuario nclsusuario = new NClsUsuario();

            Console.WriteLine("Ingresa tu nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            usuario.Contra = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine(nclsusuario.ACCESO(usuario));
            Console.ReadLine();


        }
    }
}
