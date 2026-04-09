using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ActualizarEspecialidades;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.ActualizarEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Especialidades.ActualizarEspecialidades;

namespace CasoPractico1.LogicaDeNegocio.Especialidades.ActualizarEspecialidades
{
    public class ActualizarEspecialidadesLN : IActualizarEspecialidadesLN
    {
        private IActualizarEspecialidadesAD _actualizarEspecialidades;

        public ActualizarEspecialidadesLN()
        {
            _actualizarEspecialidades = new ActualizarEspecialidadesAD();
        }

        public int Actualizar(EspecialidadesDTO laEspecialidad)
        {
            return _actualizarEspecialidades.Actualizar(laEspecialidad);
        }
    }
}
