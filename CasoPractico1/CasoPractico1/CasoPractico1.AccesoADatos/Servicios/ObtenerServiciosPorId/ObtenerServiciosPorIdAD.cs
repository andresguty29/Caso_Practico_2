using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ObtenerServiciosPordId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Servicios.ObtenerServiciosPorId
{
    public class ObtenerServiciosPorIdAD : IObtenerServiciosPorIdAD
    {


        private Contexto _elContexto;
        public ObtenerServiciosPorIdAD()
        {
            _elContexto = new Contexto();
        }



        public ServiciosDTO Obtener(int id)
        {
            ServiciosDTO laListaARetornar = (from Servicios in _elContexto.Servicios
                                            where Servicios.Id == id
                                            select new ServiciosDTO
                                            {
                                                Id = Servicios.Id,
                                                Nombre = Servicios.Nombre,
                                                Descripcion = Servicios.Descripcion,
                                                Monto = Servicios.Monto,
                                                IVA = Servicios.IVA,
                                                Especialidad = Servicios.Especialidad,
                                                Especialista = Servicios.Especialista,
                                                Clinica = Servicios.Clinica,
                                                FechaDeModificacion = Servicios.FechaDeModificacion,
                                                FechaDeRegistro = Servicios.FechaDeRegistro,
                                                Estado = Servicios.Estado,

                                            }).FirstOrDefault();
            return laListaARetornar;
        }









    }
}
