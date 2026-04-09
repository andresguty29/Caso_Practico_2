using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ListarCitasPorCliente;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Citas.ListarCitasPorCliente
{
    public class ListarCitasPorClienteAD : IListarCitasPorClienteAD
    {
        private Contexto _elContexto;

        public ListarCitasPorClienteAD()
        {
            _elContexto = new Contexto();
        }

        public List<CitasDTO> ObtenerPorIdentificacion(string identificacion)
        {
            List<CitasDTO> laListaARetornar = (from cita in _elContexto.Citas
                                               where cita.Identificacion == identificacion
                                               select new CitasDTO
                                               {
                                                   Id = cita.Id,
                                                   NombreDeLaPersona = cita.NombreDeLaPersona,
                                                   Identificacion = cita.Identificacion,
                                                   Telefono = cita.Telefono,
                                                   Correo = cita.Correo,
                                                   FechaNacimiento = cita.FechaNacimiento,
                                                   Direccion = cita.Direccion,
                                                   MontoTotal = cita.MontoTotal,
                                                   FechaDeLaCita = cita.FechaDeLaCita,
                                                   FechaDeRegistro = cita.FechaDeRegistro,
                                                   IdServicio = cita.IdServicio
                                               }).OrderByDescending(c => c.FechaDeLaCita).ToList();
            return laListaARetornar;
        }
    }
}
