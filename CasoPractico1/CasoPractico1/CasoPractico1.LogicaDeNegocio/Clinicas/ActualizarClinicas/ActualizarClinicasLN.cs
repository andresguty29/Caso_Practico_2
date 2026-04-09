using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ActualizarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ActualizarClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Clinicas.ActualizarClinicas;

namespace CasoPractico1.LogicaDeNegocio.Clinicas.ActualizarClinicas
{
    public class ActualizarClinicasLN : IActualizarClinicasLN
    {
        private IActualizarClinicasAD _actualizarClinicas;

        public ActualizarClinicasLN()
        {
            _actualizarClinicas = new ActualizarClinicasAD();
        }

        public int Actualizar(ClinicasDTO laClinica)
        {
            return _actualizarClinicas.Actualizar(laClinica);
        }
    }
}
