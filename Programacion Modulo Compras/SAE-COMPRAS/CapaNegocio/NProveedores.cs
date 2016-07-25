using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NProveedores
    {
        public static DataTable ListaProveedores()
        {
            return new DProveedores().ListaProveedores();
        }

        public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        {
            return new DProveedores().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DProveedores().Tamaño(parRegistrosPorPagina);
        }


        public static DataTable Buscar(String parNombre_Proveedor_Buscado)
        {
            DProveedores proveedores = new DProveedores();
            proveedores.Nombre_Proveedor_Buscado = parNombre_Proveedor_Buscado;

            return proveedores.Buscar(proveedores);
        }

        public static String Eliminar(int parId_Proveedor)
        {
            DProveedores proveedores = new DProveedores();
            proveedores.Id_Proveedor = parId_Proveedor;

            return proveedores.Eliminar(proveedores);
        }

        public static String Insertar(String parNombre_Proveedor, 
            String parDireccion, String parNit, String parTelefono, String parEmail)
        {
            DProveedores proveedores = new DProveedores();
            proveedores.Nombre_Proveedor = parNombre_Proveedor;
           // proveedores.Nombre_Contacto = parNombre_Contacto;
            proveedores.Direccion = parDireccion;
            proveedores.Nit = parNit;
            //proveedores.Region = parRegion;
            //proveedores.Pais = parPais;
            proveedores.Telefono = parTelefono;
            //proveedores.Fax = parFax;
            proveedores.Email = parEmail;

            return proveedores.Insertar(proveedores);
        }

        public static String Editar(int parId_Proveedor, String parNombre_Proveedor, 
            String parDireccion, String parNit, String parTelefono, String parEmail)
        {
            DProveedores proveedores = new DProveedores();
            proveedores.Id_Proveedor = parId_Proveedor;
            proveedores.Nombre_Proveedor = parNombre_Proveedor;
           // proveedores.Nombre_Contacto = parNombre_Contacto;
            proveedores.Direccion = parDireccion;
            proveedores.Nit = parNit;
            //proveedores.Region = parRegion;
            //proveedores.Pais = parPais;
            proveedores.Telefono = parTelefono;
            //proveedores.Fax = parFax;
            proveedores.Email = parEmail;

            return proveedores.Editar(proveedores);
        }
    }
}
