using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ActualizarClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Clinicas.ActualizarClinicas
{
    public class ActualizarClinicasAD : IActualizarClinicasAD
    {
        private Contexto _elContexto;

        public ActualizarClinicasAD()
        {
            _elContexto = new Contexto();
        }

        public int Actualizar(ClinicasDTO laClinica)
        {
            ClinicasAD laClinicaEnBaseDeDatos = _elContexto.Clinicas.Find(laClinica.Id);

            laClinicaEnBaseDeDatos.Nombre = laClinica.Nombre;
            laClinicaEnBaseDeDatos.Direccion = laClinica.Direccion;
            laClinicaEnBaseDeDatos.Telefono = laClinica.Telefono;
            laClinicaEnBaseDeDatos.Correo = laClinica.Correo;
            laClinicaEnBaseDeDatos.FechaDeModificacion = DateTime.Now;

            int cantidadDeRegistrosAfectados = _elContexto.SaveChanges();
            return cantidadDeRegistrosAfectados;
        }
    }
}
