using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ListarEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Especialidades.ListarEspecialidades
{
    public class ListarEspecialidadesAD : IListarEspecialidadesAD
    {
        private Contexto _elContexto;

        public ListarEspecialidadesAD()
        {
            _elContexto = new Contexto();
        }

        public List<EspecialidadesDTO> Obtener()
        {
            List<EspecialidadesDTO> laListaARetornar = (from especialidad in _elContexto.Especialidades
                                                        select new EspecialidadesDTO
                                                        {
                                                            Id = especialidad.Id,
                                                            Nombre = especialidad.Nombre,
                                                            Descripcion = especialidad.Descripcion,
                                                            FechaDeRegistro = especialidad.FechaDeRegistro,
                                                            FechaDeModificacion = especialidad.FechaDeModificacion
                                                        }).ToList();
            return laListaARetornar;
        }
    }
}
