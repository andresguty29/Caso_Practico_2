using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ListarServiciosCitas;

using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarServiciosCitas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Citas.ListarServiciosCitas;


namespace CasoPractico1.LogicaDeNegocio.Citas.ListarServiciosCitas
{
    public class ListarServiciosCitasLN : IListarServiciosCitasLN
    {

        private IListarServiciosCitasAD _listarServiciosCitasAD;
        public ListarServiciosCitasLN()
        {
            _listarServiciosCitasAD = new ListarServiciosCitasAD();
        }

        public List<ServiciosDTO> Obtener()
        {
            /*List<InventarioDto> laListaDeInventario = new List<InventarioDto>();
			laListaDeInventario.Add(ObtenerObjeto());*/
            List<ServiciosDTO> laListaDeServicios = _listarServiciosCitasAD.Obtener();

            return laListaDeServicios;
        }
    }
}
