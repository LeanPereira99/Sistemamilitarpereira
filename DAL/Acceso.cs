using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Acceso
    {
        SqlConnection cn = new SqlConnection();

        public void abrir()
        {
            cn.ConnectionString = @"Data Source=localhost;Initial Catalog=SistemaMilitarPereira;Integrated Security=True";
            cn.Open();
        }

        public void cerrar()
        {
            cn.Close();
        }

        public DataTable Read(string st, SqlParameter[] parametros)
        {
            abrir();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandType = CommandType.Text;
            da.SelectCommand.CommandText = st;
            if (parametros != null)
            {
                da.SelectCommand.Parameters.AddRange(parametros);
            }
            da.SelectCommand.Connection = cn;
            da.Fill(dt);
            cerrar();
            return dt;
        }

        public int Write(string st, SqlParameter[] parametros)
        {
            int fa = 0;
            abrir();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = st;
            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros);
            }
            cmd.Connection = cn;
            try
            {
                fa = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                fa = -1;
            }
            cerrar();
            return fa;
        }



    }
}
