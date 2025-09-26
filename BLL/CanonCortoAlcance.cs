using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CanonCortoAlcance : IEstrategiaArma
    {
        public string Nombre => "Cañón Corto Alcance";
        public double AlcanceMinimo => 0;
        public double AlcanceMaximo => 10;

        public bool PuedeDisparar(double distancia)
        {
            return distancia >= AlcanceMinimo && distancia < AlcanceMaximo;
        }

        public BEDisparo Disparar(BEObjetivo objetivo)
        {
            Random random = new Random();
            double distanciaDisparo;
            bool acierto = false;

            if (PuedeDisparar(objetivo.Distancia))
            {
                double dispersion = 1.0;
                distanciaDisparo = objetivo.Distancia + (random.NextDouble() * 2 - 1) * dispersion;

                acierto = Math.Abs(distanciaDisparo - objetivo.Distancia) <= 0.5;
            }
            else
            {
                distanciaDisparo = AlcanceMaximo - random.NextDouble();
                acierto = false;
            }

            return new BEDisparo
            {
                ObjetivoId = objetivo.Id,
                DistanciaObjetivo = objetivo.Distancia,
                ArmaUtilizada = Nombre,
                DistanciaDisparo = Math.Round(distanciaDisparo, 2),
                Acierto = acierto
            };
        }
    }
}
