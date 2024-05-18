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
            SqlConnection cn = new SqlConnection("DATA SOURCE=08LB301VESPC11;INITIAL CATALOG=Colegio; USER ID=sa; PASSWORD=system");
            cn.Open();
            return cn;
        }
    }
}
