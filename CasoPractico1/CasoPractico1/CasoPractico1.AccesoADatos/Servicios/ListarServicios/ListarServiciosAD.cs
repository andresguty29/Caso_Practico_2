using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ListarServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Servicios.ListarServicios
{
    public class ListarServiciosAD : IListarServiciosAD
    {

        private Contexto _elContexto;
        public ListarServiciosAD()
        {
            _elContexto = new Contexto();
        }




        public List<ServiciosDTO> Obtener()
        {

            List<ServiciosAD> laListaEnBaseDeDatos = _elContexto.Servicios.ToList();
            List<ServiciosDTO> laListaARetornar = (from servicios in _elContexto.Servicios
                                                   select new ServiciosDTO
                                                   {
                                                       Id = servicios.Id,
                                                       Nombre = servicios.Nombre,
                                                       Descripcion = servicios.Descripcion,
                                                       Monto = servicios.Monto,
                                                       IVA = servicios.IVA,
                                                       Especialidad = servicios.Especialidad,
                                                       Especialista = servicios.Especialista,
                                                       Clinica = servicios.Clinica,
                                                       FechaDeModificacion = servicios.FechaDeModificacion,
                                                       FechaDeRegistro = servicios.FechaDeRegistro,
                                                       Estado = servicios.Estado,
                                                   }).ToList();
            return laListaARetornar;
        }
    }


  
}
