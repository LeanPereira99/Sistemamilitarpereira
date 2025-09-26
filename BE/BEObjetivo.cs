using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEObjetivo
    {
        public string Id { get; set; }
        public double Distancia { get; set; }
        public EstadoObjetivo Estado { get; set; }
        public DateTime FechaDeteccion { get; set; }

        public BEObjetivo()
        {
            FechaDeteccion = DateTime.Now;
            Estado = EstadoObjetivo.Activo;
        }
    }
}
