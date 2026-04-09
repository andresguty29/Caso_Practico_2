using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Servicios.ActualizarServicios;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Servicios.ActualizarServicios
{
    public class ActualizarServiciosAD : IActualizarServiciosAD
    {
        private Contexto _contexto;
        public ActualizarServiciosAD()
        {
            _contexto = new Contexto();
        }



        public int Actualizar(ServiciosDTO elServicios)
        {
            ServiciosAD elServiciosEnBaseDeDatos = _contexto.Servicios.Where(Servicios => Servicios.Id == elServicios.Id).FirstOrDefault();
            elServiciosEnBaseDeDatos.FechaDeModificacion = elServicios.FechaDeModificacion;
            elServiciosEnBaseDeDatos.Nombre= elServicios.Nombre;
            elServiciosEnBaseDeDatos.Descripcion = elServicios.Descripcion;
            elServiciosEnBaseDeDatos.Monto = elServicios.   Monto;
            elServiciosEnBaseDeDatos.IVA = elServicios.IVA;
            elServiciosEnBaseDeDatos.Especialista = elServicios.Especialista;
            elServiciosEnBaseDeDatos.Clinica = elServicios.Clinica;
            elServiciosEnBaseDeDatos.Estado = elServicios.Estado;
            EntityState estado = _contexto.Entry(elServiciosEnBaseDeDatos).State = System.Data.Entity.EntityState.Modified;
            int cantidadDeDatosAgregados = _contexto.SaveChanges();
            return cantidadDeDatosAgregados;
        }














    }
}
