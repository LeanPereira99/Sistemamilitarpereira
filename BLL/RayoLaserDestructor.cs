using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RayoLaserDestructor : IEstrategiaArma
    {
        public string Nombre => "Rayo Láser Destructor Biónico";
        public double AlcanceMinimo => 50;
        public double AlcanceMaximo => 200;

        public bool PuedeDisparar(double distancia)
        {
            return distancia >= AlcanceMinimo && distancia <= AlcanceMaximo;
        }

        public BEDisparo Disparar(BEObjetivo objetivo)
        {
            Random random = new Random();
            double distanciaDisparo;
            bool acierto = false;

            if (PuedeDisparar(objetivo.Distancia))
            {
                double dispersion = 3.0;
                distanciaDisparo = objetivo.Distancia + (random.NextDouble() * 2 - 1) * dispersion;

                acierto = Math.Abs(distanciaDisparo - objetivo.Distancia) <= 2.0;
            }
            else
            {
                if (objetivo.Distancia < AlcanceMinimo)
                    distanciaDisparo = AlcanceMinimo + random.NextDouble() * 10;
                else
                    distanciaDisparo = AlcanceMaximo - random.NextDouble() * 10;
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
