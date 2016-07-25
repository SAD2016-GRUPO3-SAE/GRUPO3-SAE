using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NOrdenDetalles
    {
        public static DataTable MostrarOrdenDetalles(int parIdOrden)
        {
            return new DOrdenDetalles().MostrarOrdenDetalles(parIdOrden);
        }

        public static String Insertar(String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            DOrdenDetalles ordenDetalles = new DOrdenDetalles();
            ordenDetalles.Nombre_Producto = parNombre_Producto;
            ordenDetalles.Cantidad = parCantidad;
            ordenDetalles.Precio_Unitario = parPrecio_Unitario;
            ordenDetalles.Descuento = parDescuento;

            return ordenDetalles.Insertar(ordenDetalles);
        }

        public static String Editar(int parIdOrden, String parNombre_Producto, int parCantidad,
            decimal parPrecio_Unitario, decimal parDescuento)
        {
            DOrdenDetalles ordenDetalles = new DOrdenDetalles();
            ordenDetalles.Id_Orden = parIdOrden;
            ordenDetalles.Nombre_Producto = parNombre_Producto;
            ordenDetalles.Cantidad = parCantidad;
            ordenDetalles.Precio_Unitario = parPrecio_Unitario;
            ordenDetalles.Descuento = parDescuento;

            return ordenDetalles.Editar(ordenDetalles);
        }

    }
}
