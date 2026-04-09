using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasoPractico1.Abstracciones.ModelosParaUI;

namespace CasoPractico1.Abstracciones.AccesoADatos.Servicios.CrearServicios
{
    public interface ICrearServiciosAD
    {
        Task<int> Guardar(ServiciosDTO elServicios);
    }
}
