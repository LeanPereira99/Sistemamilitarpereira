using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RadarService
    {
        private Random _random;
        private int _contadorObjetivos;

        public RadarService()
        {
            _random = new Random();
            _contadorObjetivos = 1;
        }

        public List<BEObjetivo> GenerarObjetivos()
        {
            List<BEObjetivo> objetivos = new List<BEObjetivo>();
            int cantidad = _random.Next(5, 9);

            for (int i = 0; i < cantidad; i++)
            {
                objetivos.Add(new BEObjetivo
                {
                    Id = $"OBJ-{_contadorObjetivos:000}",
                    Distancia = Math.Round(_random.NextDouble() * 200 + 1, 2),
                    Estado = EstadoObjetivo.Activo
                });
                _contadorObjetivos++;
            }

            return objetivos;
        }

    }
}
