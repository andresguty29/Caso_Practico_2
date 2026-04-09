using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ObtenerClinicasPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Clinicas.ObtenerClinicasPorId
{
    public class ObtenerClinicasPorIdAD : IObtenerClinicasPorIdAD
    {
        private Contexto _elContexto;

        public ObtenerClinicasPorIdAD()
        {
            _elContexto = new Contexto();
        }

        public ClinicasDTO Obtener(int id)
        {
            ClinicasAD laClinicaEnBaseDeDatos = _elContexto.Clinicas.Find(id);

            ClinicasDTO laClinicaARetornar = new ClinicasDTO
            {
                Id = laClinicaEnBaseDeDatos.Id,
                Nombre = laClinicaEnBaseDeDatos.Nombre,
                Direccion = laClinicaEnBaseDeDatos.Direccion,
                Telefono = laClinicaEnBaseDeDatos.Telefono,
                Correo = laClinicaEnBaseDeDatos.Correo,
                FechaDeRegistro = laClinicaEnBaseDeDatos.FechaDeRegistro,
                FechaDeModificacion = laClinicaEnBaseDeDatos.FechaDeModificacion
            };

            return laClinicaARetornar;
        }
    }
}
