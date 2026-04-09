using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ObtenerEspecialidadesPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.ObtenerEspecialidadesPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Especialidades.ObtenerEspecialidadesPorId;

namespace CasoPractico1.LogicaDeNegocio.Especialidades.ObtenerEspecialidadesPorId
{
    public class ObtenerEspecialidadesPorIdLN : IObtenerEspecialidadesPorIdLN
    {
        private IObtenerEspecialidadesPorIdAD _obtenerEspecialidadesPorId;

        public ObtenerEspecialidadesPorIdLN()
        {
            _obtenerEspecialidadesPorId = new ObtenerEspecialidadesPorIdAD();
        }

        public EspecialidadesDTO Obtener(int id)
        {
            return _obtenerEspecialidadesPorId.Obtener(id);
        }
    }
}
