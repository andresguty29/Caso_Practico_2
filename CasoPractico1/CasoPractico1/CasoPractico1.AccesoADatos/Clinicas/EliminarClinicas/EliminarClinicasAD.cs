using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.EliminarClinicas;
using CasoPractico1.AccesoADatos.Modelos;
using Inventario.AccesoADatos;

namespace CasoPractico1.AccesoADatos.Clinicas.EliminarClinicas
{
    public class EliminarClinicasAD : IEliminarClinicasAD
    {
        private Contexto _elContexto;

        public EliminarClinicasAD()
        {
            _elContexto = new Contexto();
        }

        public int Eliminar(int id)
        {
            ClinicasAD laClinicaAEliminar = _elContexto.Clinicas.Find(id);

            if (laClinicaAEliminar != null)
            {
                _elContexto.Clinicas.Remove(laClinicaAEliminar);
                int cantidadDeRegistrosAfectados = _elContexto.SaveChanges();
                return cantidadDeRegistrosAfectados;
            }

            return 0;
        }
    }
}
