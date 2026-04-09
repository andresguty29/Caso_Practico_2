using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.AccesoADatos.Citas.CrearCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.CrearCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.General;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.AccesoADatos.Citas.CrearCitas;
using CasoPractico1.LogicaDeNegocio.General;

namespace CasoPractico1.LogicaDeNegocio.Citas.CrearCitas
{
    public class CrearCitasLN : ICrearCitasLN
    {

        private ICrearCitasAD _crearCitasAD;
        private IFecha _fecha;

        public CrearCitasLN()
        {
            _crearCitasAD = new CrearCitasAD();
            _fecha = new Fecha();
        }



        public async Task<int> Guardar(CitasDTO lasCitas)
        {
            lasCitas.FechaDeRegistro = _fecha.ObtenerFechaSegunZona();
            
            int cantidadDeResultados = await _crearCitasAD.Guardar(lasCitas);
            return cantidadDeResultados;
        }


    }
}
