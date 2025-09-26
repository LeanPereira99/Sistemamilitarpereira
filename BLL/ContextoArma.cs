using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ContextoArma
    {
        private IEstrategiaArma _estrategia;
        private List<IEstrategiaArma> _armasDisponibles;

        public ContextoArma()
        {
            _armasDisponibles = new List<IEstrategiaArma>
            {
                new CanonCortoAlcance(),
                new CanonUltrasonico(),
                new RayoLaserDestructor()
            };
            _estrategia = _armasDisponibles[0];
        }

        public void SetEstrategia(IEstrategiaArma estrategia)
        {
            _estrategia = estrategia;
        }

        public IEstrategiaArma SeleccionarArmaOptima(double distancia)
        {
            var armaOptima = _armasDisponibles.FirstOrDefault(a => a.PuedeDisparar(distancia));
            if (armaOptima != null)
            {
                SetEstrategia(armaOptima);
                return armaOptima;
            }
            return _estrategia;
        }

        public bool PuedeDispararConArmaActual(double distancia)
        {
            return _estrategia.PuedeDisparar(distancia);
        }

        public string ObtenerArmaSugerida(double distancia)
        {
            var armaSugerida = _armasDisponibles.FirstOrDefault(a => a.PuedeDisparar(distancia));
            return armaSugerida?.Nombre ?? "Ninguna arma disponible para esta distancia";
        }

        public BEDisparo Disparar(BEObjetivo objetivo)
        {
            return _estrategia.Disparar(objetivo);
        }

        public IEstrategiaArma GetArmaActual()
        {
            return _estrategia;
        }

        public List<IEstrategiaArma> GetArmasDisponibles()
        {
            return _armasDisponibles;
        }

        public IEstrategiaArma GetArmaPorNombre(string nombre)
        {
            return _armasDisponibles.FirstOrDefault(a => a.Nombre == nombre);
        }
    }
}
