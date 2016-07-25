using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DConexion
    {
  
        public static String CnBDEmpresa = "Data Source=168.234.74.21;Initial Catalog=DB3;User ID=db3admin;Password=db3admin$";
        public static String CnMaster = "Data Source=168.234.74.21;Initial Catalog=DB3;User ID=db3admin;Password=db3admin$";

        public String ChequearConexion()
        {
            String mensaje = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();
                mensaje = "Y";
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            finally
            {
                SqlConexion.Close();
            }

            return mensaje;
        }
    }

}