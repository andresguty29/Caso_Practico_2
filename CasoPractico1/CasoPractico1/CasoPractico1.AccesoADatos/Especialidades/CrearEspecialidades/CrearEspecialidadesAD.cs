using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.CrearEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Especialidades.CrearEspecialidades
{
    public class CrearEspecialidadesAD : ICrearEspecialidadesAD
    {
        private Contexto _elContexto;

        public CrearEspecialidadesAD()
        {
            _elContexto = new Contexto();
        }

        public async Task<int> Guardar(EspecialidadesDTO laEspecialidad)
        {
            EspecialidadesAD laEspecialidadAGuardar = new EspecialidadesAD
            {
                Nombre = laEspecialidad.Nombre,
                Descripcion = laEspecialidad.Descripcion,
                FechaDeRegistro = DateTime.Now
            };

            _elContexto.Especialidades.Add(laEspecialidadAGuardar);
            int cantidadDeRegistrosAfectados = await _elContexto.SaveChangesAsync();
            return cantidadDeRegistrosAfectados;
        }
    }
}
