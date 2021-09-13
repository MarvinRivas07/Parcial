using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    class ClsVenta
    {
        private int id_producto;
        private string nombre_producto;
        private string decripcion_producto;
        private double precio_venta;
        private int cantidad;

        public ClsVenta(int id_producto, string nombre_producto, string decripcion_producto, double precio_venta, int cantidad)
        {
            this.id_producto = id_producto;
            this.nombre_producto = nombre_producto;
            this.decripcion_producto = decripcion_producto;
            this.precio_venta = precio_venta;
            this.cantidad = cantidad;
        }

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Decripcion_producto { get => decripcion_producto; set => decripcion_producto = value; }
        public double Precio_venta { get => precio_venta; set => precio_venta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
