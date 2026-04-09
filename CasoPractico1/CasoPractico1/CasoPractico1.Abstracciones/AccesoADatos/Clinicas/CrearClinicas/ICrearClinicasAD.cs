using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModelosParaUI;

namespace CasoPractico1.Abstracciones.AccesoADatos.Clinicas.CrearClinicas
{
    public interface ICrearClinicasAD
    {
        Task<int> Guardar(ClinicasDTO laClinica);
    }
}
