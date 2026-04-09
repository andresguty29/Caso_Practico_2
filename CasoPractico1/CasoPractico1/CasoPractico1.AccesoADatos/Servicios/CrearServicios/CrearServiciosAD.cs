using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.CrearServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Servicios.CrearServicios
{
    public class CrearServiciosAD : ICrearServiciosAD
    {
        private Contexto _contexto;

        public CrearServiciosAD()
        {
            _contexto = new Contexto();
        }


        public async Task<int> Guardar(ServiciosDTO elServicios)
        {
            //_contexto.Database.ExecuteSqlCommand("EXE PROC @elParametro, @elParametro2", "", "");
            ServiciosAD elServiciosAGuardar = ConvertirObjetoParaAD(elServicios);
            _contexto.Servicios.Add(elServiciosAGuardar);
            EntityState estado = _contexto.Entry(elServiciosAGuardar).State = System.Data.Entity.EntityState.Added;
            int cantidadDeDatosAgregados = await _contexto.SaveChangesAsync();
            return cantidadDeDatosAgregados;
        }


        private ServiciosAD ConvertirObjetoParaAD(ServiciosDTO servicios)
        {
            return new ServiciosAD
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
               
            };
        }

    }
}
