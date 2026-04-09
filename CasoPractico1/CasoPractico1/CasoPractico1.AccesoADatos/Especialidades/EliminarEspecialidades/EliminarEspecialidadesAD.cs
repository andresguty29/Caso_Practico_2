using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.EliminarEspecialidades;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Especialidades.EliminarEspecialidades
{
    public class EliminarEspecialidadesAD : IEliminarEspecialidadesAD
    {
        private Contexto _elContexto;

        public EliminarEspecialidadesAD()
        {
            _elContexto = new Contexto();
        }

        public int Eliminar(int id)
        {
            EspecialidadesAD laEspecialidadAEliminar = _elContexto.Especialidades.Find(id);

            if (laEspecialidadAEliminar != null)
            {
                _elContexto.Especialidades.Remove(laEspecialidadAEliminar);
                int cantidadDeRegistrosAfectados = _elContexto.SaveChanges();
                return cantidadDeRegistrosAfectados;
            }

            return 0;
        }
    }
}
