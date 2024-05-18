using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CRUD_COLEGIO_BD
{
    class conexion
    {
        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("LAPTOP-33P39HMO;DATABASE=Colegio;INTEGRATED SECURITY=true;");
            cn.Open();
            return cn;
        }
    }
}
