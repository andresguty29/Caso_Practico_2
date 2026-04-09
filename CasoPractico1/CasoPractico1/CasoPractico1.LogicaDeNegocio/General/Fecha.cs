using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.LogicaDeNegocio.General;

namespace CasoPractico1.LogicaDeNegocio.General
{
    public class Fecha :IFecha
    {

        public DateTime ObtenerFechaSegunZona()
        {
            int zonaHoraria = -6;
            return DateTime.UtcNow.AddHours(zonaHoraria);
        }
    }
}
