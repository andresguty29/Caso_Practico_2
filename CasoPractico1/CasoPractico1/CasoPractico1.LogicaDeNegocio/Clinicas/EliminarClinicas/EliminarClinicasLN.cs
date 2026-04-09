using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.EliminarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.EliminarClinicas;
using CasoPractico1.AccesoADatos.Clinicas.EliminarClinicas;

namespace CasoPractico1.LogicaDeNegocio.Clinicas.EliminarClinicas
{
    public class EliminarClinicasLN : IEliminarClinicasLN
    {
        private IEliminarClinicasAD _eliminarClinicas;

        public EliminarClinicasLN()
        {
            _eliminarClinicas = new EliminarClinicasAD();
        }

        public int Eliminar(int id)
        {
            return _eliminarClinicas.Eliminar(id);
        }
    }
}
