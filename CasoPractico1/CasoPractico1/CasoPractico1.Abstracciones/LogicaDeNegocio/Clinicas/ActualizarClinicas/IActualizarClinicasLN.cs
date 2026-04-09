using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModelosParaUI;

namespace CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ActualizarClinicas
{
    public interface IActualizarClinicasLN
    {
        int Actualizar(ClinicasDTO laClinica);
    }
}
