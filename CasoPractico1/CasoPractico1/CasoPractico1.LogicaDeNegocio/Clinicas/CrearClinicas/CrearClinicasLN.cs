using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Clinicas.CrearClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.CrearClinicas;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Clinicas.CrearClinicas;

namespace CasoPractico1.LogicaDeNegocio.Clinicas.CrearClinicas
{
    public class CrearClinicasLN : ICrearClinicasLN
    {
        private ICrearClinicasAD _crearClinicas;

        public CrearClinicasLN()
        {
            _crearClinicas = new CrearClinicasAD();
        }

        public async Task<int> Guardar(ClinicasDTO laClinica)
        {
            return await _crearClinicas.Guardar(laClinica);
        }
    }
}
