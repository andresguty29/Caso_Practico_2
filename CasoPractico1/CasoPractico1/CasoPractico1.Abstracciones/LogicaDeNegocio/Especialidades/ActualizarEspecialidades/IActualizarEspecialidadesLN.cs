using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModelosParaUI;

namespace CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.ActualizarEspecialidades
{
    public interface IActualizarEspecialidadesLN
    {
        int Actualizar(EspecialidadesDTO laEspecialidad);
    }
}
