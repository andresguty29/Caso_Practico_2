using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.CrearServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.General;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.CrearServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Servicios.CrearServicios;
using CasoPractico1.LogicaDeNegocio.General;

namespace CasoPractico1.LogicaDeNegocio.Servicios
{
    public class CrearServiciosLN : ICrearServiciosLN
    {


        private ICrearServiciosAD _crearServiciosAD;
        private IFecha _fecha;


        public CrearServiciosLN()
        {
            _crearServiciosAD = new CrearServiciosAD();
            _fecha = new Fecha();
        }

        public async Task<int> Guardar(ServiciosDTO elServicios)
        {
            elServicios.FechaDeRegistro = _fecha.ObtenerFechaSegunZona();
            elServicios.Estado = true;
            int cantidadDeResultados = await _crearServiciosAD.Guardar(elServicios);
            return cantidadDeResultados;
        }






    }


}
