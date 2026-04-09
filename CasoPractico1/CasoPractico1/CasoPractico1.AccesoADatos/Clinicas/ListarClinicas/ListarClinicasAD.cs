using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ListarClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Clinicas.ListarClinicas
{
    public class ListarClinicasAD : IListarClinicasAD
    {
        private Contexto _elContexto;

        public ListarClinicasAD()
        {
            _elContexto = new Contexto();
        }

        public List<ClinicasDTO> Obtener()
        {
            List<ClinicasDTO> laListaARetornar = (from clinica in _elContexto.Clinicas
                                                  select new ClinicasDTO
                                                  {
                                                      Id = clinica.Id,
                                                      Nombre = clinica.Nombre,
                                                      Direccion = clinica.Direccion,
                                                      Telefono = clinica.Telefono,
                                                      Correo = clinica.Correo,
                                                      FechaDeRegistro = clinica.FechaDeRegistro,
                                                      FechaDeModificacion = clinica.FechaDeModificacion
                                                  }).ToList();
            return laListaARetornar;
        }
    }
}
