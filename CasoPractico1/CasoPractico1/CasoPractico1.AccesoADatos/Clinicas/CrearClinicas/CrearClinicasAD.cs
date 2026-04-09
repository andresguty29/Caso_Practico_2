using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.CrearClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Clinicas.CrearClinicas
{
    public class CrearClinicasAD : ICrearClinicasAD
    {
        private Contexto _elContexto;

        public CrearClinicasAD()
        {
            _elContexto = new Contexto();
        }

        public async Task<int> Guardar(ClinicasDTO laClinica)
        {
            ClinicasAD laClinicaAGuardar = new ClinicasAD
            {
                Nombre = laClinica.Nombre,
                Direccion = laClinica.Direccion,
                Telefono = laClinica.Telefono,
                Correo = laClinica.Correo,
                FechaDeRegistro = DateTime.Now
            };

            _elContexto.Clinicas.Add(laClinicaAGuardar);
            int cantidadDeRegistrosAfectados = await _elContexto.SaveChangesAsync();
            return cantidadDeRegistrosAfectados;
        }
    }
}
