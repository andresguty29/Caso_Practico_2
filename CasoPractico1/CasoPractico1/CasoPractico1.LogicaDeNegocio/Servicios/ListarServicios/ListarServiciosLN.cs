using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ListarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ListarServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Servicios.ListarServicios;

namespace CasoPractico1.LogicaDeNegocio.Servicios.ListarServicios
{
    public class ListarServiciosLN : IListarServiciosLN
    {

        private IListarServiciosAD _listarServiciosAD;
        public ListarServiciosLN()
        {
            _listarServiciosAD = new ListarServiciosAD();
        }

        public List<ServiciosDTO> Obtener()
        {
            /*List<InventarioDto> laListaDeInventario = new List<InventarioDto>();
			laListaDeInventario.Add(ObtenerObjeto());*/
            List<ServiciosDTO> laListaDeServicios = _listarServiciosAD.Obtener();

            return laListaDeServicios;
        }



    }
}
