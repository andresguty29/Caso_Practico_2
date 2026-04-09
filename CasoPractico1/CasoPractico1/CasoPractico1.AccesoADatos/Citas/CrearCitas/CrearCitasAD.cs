using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.CrearCitas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Citas.CrearCitas
{
    public class CrearCitasAD : ICrearCitasAD
    {

        private Contexto _contexto;

        public CrearCitasAD()
        {
            _contexto = new Contexto();
        }


        public async Task<int> Guardar(CitasDTO lasCitas)
        {
            //_contexto.Database.ExecuteSqlCommand("EXE PROC @elParametro, @elParametro2", "", "");
            CitasAD lasCitasAGuardar = ConvertirObjetoParaAD(lasCitas);
            _contexto.Citas.Add(lasCitasAGuardar);
            EntityState estado = _contexto.Entry(lasCitasAGuardar).State = System.Data.Entity.EntityState.Added;
            int cantidadDeDatosAgregados = await _contexto.SaveChangesAsync();
            return cantidadDeDatosAgregados;
        }



        private CitasAD ConvertirObjetoParaAD(CitasDTO citas)
        {
            return new CitasAD
            {
                NombreDeLaPersona = citas.NombreDeLaPersona,
                Identificacion = citas.Identificacion,
                Telefono = citas.Telefono,
                Correo = citas.Correo,
                FechaNacimiento = citas.FechaNacimiento,
                Direccion = citas.Direccion,
                MontoTotal = citas.MontoTotal,
                FechaDeLaCita = citas.FechaDeLaCita,
                FechaDeRegistro = citas.FechaDeRegistro,
                IdServicio = citas.IdServicio

            };
        }














    }
}
