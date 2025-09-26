using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEDisparo
    {
        public int Id { get; set; }
        public string ObjetivoId { get; set; }
        public double DistanciaObjetivo { get; set; }
        public string ArmaUtilizada { get; set; }
        public double DistanciaDisparo { get; set; }
        public bool Acierto { get; set; }
        public DateTime FechaHora { get; set; }

        public BEDisparo()
        {
            FechaHora = DateTime.Now;
        }
    }
}
