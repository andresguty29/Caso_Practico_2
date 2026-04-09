using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ListarCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarCitas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Citas.ListarCitas;

namespace CasoPractico1.LogicaDeNegocio.Citas.ListarCitas
{
    public  class ListarCitasLN : IListarCitasLN
    {


        private IListarCitasAD _listarCitasAD;
		public ListarCitasLN()
        {
            _listarCitasAD = new ListarCitasAD();
        }

        public List<CitasDTO> Obtener(int id)
        {
            /*List<InventarioDto> laListaDeInventario = new List<InventarioDto>();
			laListaDeInventario.Add(ObtenerObjeto());*/
            List<CitasDTO> laListaDeCitas = _listarCitasAD.Obtener(id);

            return laListaDeCitas;
        }






    }
}
