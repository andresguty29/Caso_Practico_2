using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ObtenerServiciosPordId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ObtenerServiciosPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Servicios.ObtenerServiciosPorId;

namespace CasoPractico1.LogicaDeNegocio.Servicios.ObtenerServiciosPorId
{
    public class ObtenerServiciosPorIdLN : IObtenerServiciosPorIdLN
    {

        private IObtenerServiciosPorIdAD _obtenerServiciosPorId;
        public ObtenerServiciosPorIdLN()
        {
            _obtenerServiciosPorId = new ObtenerServiciosPorIdAD();
        }



        public ServiciosDTO Obtener(int id)
        {
            ServiciosDTO elServicios = _obtenerServiciosPorId.Obtener(id);
            return elServicios;
        }









    }

}
