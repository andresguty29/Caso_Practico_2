using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Especialidades.ListarEspecialidades;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Especialidades.ListarEspecialidades;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Especialidades.ListarEspecialidades;

namespace CasoPractico1.LogicaDeNegocio.Especialidades.ListarEspecialidades
{
    public class ListarEspecialidadesLN : IListarEspecialidadesLN
    {
        private IListarEspecialidadesAD _listarEspecialidades;

        public ListarEspecialidadesLN()
        {
            _listarEspecialidades = new ListarEspecialidadesAD();
        }

        public List<EspecialidadesDTO> Obtener()
        {
            return _listarEspecialidades.Obtener();
        }
    }
}
