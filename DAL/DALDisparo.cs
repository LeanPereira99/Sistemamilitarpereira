using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DALDisparo
    {
        private Acceso acceso = new Acceso();

        public void InsertarDisparo(BEDisparo disparo)
        {
            string query = @"INSERT INTO Disparos (ObjetivoId, DistanciaObjetivo, ArmaUtilizada, DistanciaDisparo, Acierto, FechaHora) 
                           VALUES (@ObjetivoId, @DistanciaObjetivo, @ArmaUtilizada, @DistanciaDisparo, @Acierto, @FechaHora)";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@ObjetivoId", disparo.ObjetivoId),
                new SqlParameter("@DistanciaObjetivo", disparo.DistanciaObjetivo),
                new SqlParameter("@ArmaUtilizada", disparo.ArmaUtilizada),
                new SqlParameter("@DistanciaDisparo", disparo.DistanciaDisparo),
                new SqlParameter("@Acierto", disparo.Acierto),
                new SqlParameter("@FechaHora", disparo.FechaHora)
            };

            acceso.Write(query, parametros);
        }

        public List<BEDisparo> ObtenerTodos()
        {
            List<BEDisparo> disparos = new List<BEDisparo>();
            string query = "SELECT * FROM Disparos ORDER BY FechaHora DESC";

            DataTable dt = acceso.Read(query, null);

            foreach (DataRow row in dt.Rows)
            {
                BEDisparo disparo = new BEDisparo
                {
                    Id = Convert.ToInt32(row["Id"]),
                    ObjetivoId = row["ObjetivoId"].ToString(),
                    DistanciaObjetivo = Convert.ToDouble(row["DistanciaObjetivo"]),
                    ArmaUtilizada = row["ArmaUtilizada"].ToString(),
                    DistanciaDisparo = Convert.ToDouble(row["DistanciaDisparo"]),
                    Acierto = Convert.ToBoolean(row["Acierto"]),
                    FechaHora = Convert.ToDateTime(row["FechaHora"])
                };
                disparos.Add(disparo);
            }

            return disparos;
        }
    }
}
