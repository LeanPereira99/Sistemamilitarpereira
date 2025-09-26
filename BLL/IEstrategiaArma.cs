using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IEstrategiaArma
    {
        string Nombre { get; }
        double AlcanceMinimo { get; }
        double AlcanceMaximo { get; }
        bool PuedeDisparar(double distancia);
        BEDisparo Disparar(BEObjetivo objetivo);
    }
}
