using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.CrearEspecialidades;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.CrearEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Especialidades.CrearEspecialidades;

namespace CasoPractico1.LogicaDeNegocio.Especialidades.CrearEspecialidades
{
    public class CrearEspecialidadesLN : ICrearEspecialidadesLN
    {
        private ICrearEspecialidadesAD _crearEspecialidades;

        public CrearEspecialidadesLN()
        {
            _crearEspecialidades = new CrearEspecialidadesAD();
        }

        public async Task<int> Guardar(EspecialidadesDTO laEspecialidad)
        {
            return await _crearEspecialidades.Guardar(laEspecialidad);
        }
    }
}
