using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ActualizarEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Especialidades.ActualizarEspecialidades
{
    public class ActualizarEspecialidadesAD : IActualizarEspecialidadesAD
    {
        private Contexto _elContexto;

        public ActualizarEspecialidadesAD()
        {
            _elContexto = new Contexto();
        }

        public int Actualizar(EspecialidadesDTO laEspecialidad)
        {
            EspecialidadesAD laEspecialidadEnBaseDeDatos = _elContexto.Especialidades.Find(laEspecialidad.Id);

            laEspecialidadEnBaseDeDatos.Nombre = laEspecialidad.Nombre;
            laEspecialidadEnBaseDeDatos.Descripcion = laEspecialidad.Descripcion;
            laEspecialidadEnBaseDeDatos.FechaDeModificacion = DateTime.Now;

            int cantidadDeRegistrosAfectados = _elContexto.SaveChanges();
            return cantidadDeRegistrosAfectados;
        }
    }
}
