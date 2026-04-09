using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.EliminarEspecialidades;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.EliminarEspecialidades;
using CasoPractico1.AccesoADatos.Especialidades.EliminarEspecialidades;

namespace CasoPractico1.LogicaDeNegocio.Especialidades.EliminarEspecialidades
{
    public class EliminarEspecialidadesLN : IEliminarEspecialidadesLN
    {
        private IEliminarEspecialidadesAD _eliminarEspecialidades;

        public EliminarEspecialidadesLN()
        {
            _eliminarEspecialidades = new EliminarEspecialidadesAD();
        }

        public int Eliminar(int id)
        {
            return _eliminarEspecialidades.Eliminar(id);
        }
    }
}
