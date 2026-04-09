using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ObtenerCitasPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ObtenerCitasPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Citas.ObtenerCitasPorId;

namespace CasoPractico1.LogicaDeNegocio.Citas
{
    public class ObtenerCitasPorIdLN : IObtenerCitasPorIdLN
    {

        private IObtenerCitasPorIdAD _obtenerCitasPorId;
        public ObtenerCitasPorIdLN()
        {
            _obtenerCitasPorId = new ObtenerCitasPorIdAD();
        }




        public BuscarCitaDTO Obtener(int id)
        {
            BuscarCitaDTO lasCitas = _obtenerCitasPorId.Obtener(id);
            return lasCitas;
        }













    }
}
