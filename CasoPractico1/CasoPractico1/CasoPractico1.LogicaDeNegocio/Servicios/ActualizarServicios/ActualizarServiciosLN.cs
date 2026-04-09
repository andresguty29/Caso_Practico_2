using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ActualizarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.General;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ActualizarServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Servicios.ActualizarServicios;
using CasoPractico1.LogicaDeNegocio.General;

namespace CasoPractico1.LogicaDeNegocio.Servicios.ActualizarServicios
{
    public class ActualizarServiciosLN : IActualizarServiciosLN
    {

        private IActualizarServiciosAD _actualizarServiciosAD;
        private IFecha _fecha;

        public ActualizarServiciosLN()
        {
            _actualizarServiciosAD = new ActualizarServiciosAD();
            _fecha = new Fecha();
        }





        public int Actualizar(ServiciosDTO elServicios)
        {
            elServicios.FechaDeModificacion = _fecha.ObtenerFechaSegunZona();
            
            int cantidadDeResultados = _actualizarServiciosAD.Actualizar(elServicios);
            return cantidadDeResultados;
        }








    }
}
