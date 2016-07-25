using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NReportes
    {
        public static DataTable MostrarTop10Proveedores(String parFechaInicial, String parFechaFinal)
        {
            return new DReportes().MostrarTop10Proveedores(parFechaInicial, parFechaFinal);
        }

        public static DataTable MostrarTop10Empleados(String parFechaInicial, String parFechaFinal)
        {
            return new DReportes().MostrarTop10Empleados(parFechaInicial, parFechaFinal);
        }

        public static DataTable MostrarTop10Productos(String parFechaInicial, String parFechaFinal)
        {
            return new DReportes().MostrarTop10Productos(parFechaInicial, parFechaFinal);
        }

        public static DataTable MostrarHistorialProveedor(String parFechaInicial, String parFechaFinal,
            String parProveedor)
        {
            return new DReportes().MostrarHistorialProveedor(parFechaInicial, parFechaFinal, parProveedor);
        }

        public static DataTable MostrarHistorialEmpleado(String parFechaInicial, String parFechaFinal,
            String parEmpleado)
        {
            return new DReportes().MostrarHistorialEmpleado(parFechaInicial, parFechaFinal, parEmpleado);
        }

        public static DataTable MostrarHistorialProducto(String parFechaInicial, String parFechaFinal,
            String parProducto)
        {
            return new DReportes().MostrarHistorialProducto(parFechaInicial, parFechaFinal, parProducto);
        }
    }
}