using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DisparoService
    {
        private DALDisparo _dalDisparo;

        public DisparoService()
        {
            _dalDisparo = new DALDisparo();
        }

        public void ProcesarDisparo(BEDisparo disparo)
        {
            _dalDisparo.InsertarDisparo(disparo);
        }

        public List<BEDisparo> ObtenerHistorial()
        {
            return _dalDisparo.ObtenerTodos();
        }
    }
}
