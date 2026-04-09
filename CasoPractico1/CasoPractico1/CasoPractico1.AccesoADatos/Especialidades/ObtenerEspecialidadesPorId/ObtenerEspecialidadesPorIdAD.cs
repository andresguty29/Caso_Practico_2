using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ObtenerEspecialidadesPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Especialidades.ObtenerEspecialidadesPorId
{
    public class ObtenerEspecialidadesPorIdAD : IObtenerEspecialidadesPorIdAD
    {
        private Contexto _elContexto;

        public ObtenerEspecialidadesPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public EspecialidadesDTO Obtener(int id)
        {
            EspecialidadesAD laEspecialidadEnBaseDeDatos = _elContexto.Especialidades.Find(id);

            EspecialidadesDTO laEspecialidadARetornar = new EspecialidadesDTO
            {
                Id = laEspecialidadEnBaseDeDatos.Id,
                Nombre = laEspecialidadEnBaseDeDatos.Nombre,
                Descripcion = laEspecialidadEnBaseDeDatos.Descripcion,
                FechaDeRegistro = laEspecialidadEnBaseDeDatos.FechaDeRegistro,
                FechaDeModificacion = laEspecialidadEnBaseDeDatos.FechaDeModificacion
            };

            return laEspecialidadARetornar;
        }
    }
}
