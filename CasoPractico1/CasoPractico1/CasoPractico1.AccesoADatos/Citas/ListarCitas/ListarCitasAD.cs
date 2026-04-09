using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ListarCitas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Citas.ListarCitas
{
    public class ListarCitasAD : IListarCitasAD
    {


        private Contexto _elContexto;

        public ListarCitasAD()
        {
            _elContexto = new Contexto();
          
        }



        public List<CitasDTO> Obtener(int id)
        {

            List<CitasAD> laListaEnBaseDeDatos = _elContexto.Citas.ToList();
            List<CitasDTO> laListaARetornar = (from citas in _elContexto.Citas
                                               where citas.IdServicio == id
                                               select new CitasDTO
                                                   {
                                                       Id = citas.Id,
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
                                                   }).ToList();
            return laListaARetornar;
        }


















    }
}
