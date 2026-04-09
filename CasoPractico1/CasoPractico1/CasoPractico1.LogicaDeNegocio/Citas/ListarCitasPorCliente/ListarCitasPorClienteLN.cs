using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.ListarCitasPorCliente;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarCitasPorCliente;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Citas.ListarCitasPorCliente;

namespace CasoPractico1.LogicaDeNegocio.Citas.ListarCitasPorCliente
{
    public class ListarCitasPorClienteLN : IListarCitasPorClienteLN
    {
        private IListarCitasPorClienteAD _listarCitasPorCliente;

        public ListarCitasPorClienteLN()
        {
            _listarCitasPorCliente = new ListarCitasPorClienteAD();
        }

        public List<CitasDTO> ObtenerPorIdentificacion(string identificacion)
        {
            return _listarCitasPorCliente.ObtenerPorIdentificacion(identificacion);
        }
    }
}
