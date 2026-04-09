using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ObtenerCitasPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Citas.ObtenerCitasPorId
{
    public class ObtenerCitasPorIdAD : IObtenerCitasPorIdAD
    {



        private Contexto _elContexto;
        public ObtenerCitasPorIdAD()
        {
            _elContexto = new Contexto();
        }





        public BuscarCitaDTO Obtener(int id)
        {
            BuscarCitaDTO laListaARetornar = (from citas in _elContexto.Citas
                                              join servicio in _elContexto.Servicios
                                              on citas.IdServicio equals servicio.Id
                                              where citas.Id == id
                                              select new BuscarCitaDTO
                                              {
                                                  NombreDeLaPersona = citas.NombreDeLaPersona,
                                                  Telefono = citas.Telefono,
                                                  Correo = citas.Correo,
                                                  Identificacion = citas.Identificacion,
                                                  FechaNacimiento = citas.FechaNacimiento,
                                                  Direccion = citas.Direccion,
                                                  Nombre = servicio.Nombre,
                                                  Especialidad = servicio.Especialidad,
                                                  Especialista = servicio.Especialista,
                                                  MontoTotal = citas.MontoTotal,
                                                  FechaDeLaCita = citas.FechaDeLaCita,
                                                  FechaDeRegistroCita = citas.FechaDeRegistro
                                              }).FirstOrDefault();
            return laListaARetornar;
        }













    }
}
