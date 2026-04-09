using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ObtenerClinicasPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ObtenerClinicasPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Clinicas.ObtenerClinicasPorId;

namespace CasoPractico1.LogicaDeNegocio.Clinicas.ObtenerClinicasPorId
{
    public class ObtenerClinicasPorIdLN : IObtenerClinicasPorIdLN
    {
        private IObtenerClinicasPorIdAD _obtenerClinicasPorId;

        public ObtenerClinicasPorIdLN()
        {
            _obtenerClinicasPorId = new ObtenerClinicasPorIdAD();
        }

        public ClinicasDTO Obtener(int id)
        {
            return _obtenerClinicasPorId.Obtener(id);
        }
    }
}
