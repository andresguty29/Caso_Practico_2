using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.ListarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ListarClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Clinicas.ListarClinicas;

namespace CasoPractico1.LogicaDeNegocio.Clinicas.ListarClinicas
{
    public class ListarClinicasLN : IListarClinicasLN
    {
        private IListarClinicasAD _listarClinicas;

        public ListarClinicasLN()
        {
            _listarClinicas = new ListarClinicasAD();
        }

        public List<ClinicasDTO> Obtener()
        {
            return _listarClinicas.Obtener();
        }
    }
}
