
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ActualizarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.CrearServicios;

using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ListarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ObtenerServiciosPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.LogicaDeNegocio.Citas.ListarCitas;
using CasoPractico1.LogicaDeNegocio.Servicios;
using CasoPractico1.LogicaDeNegocio.Servicios.ActualizarServicios;
using CasoPractico1.LogicaDeNegocio.Servicios.ListarServicios;
using CasoPractico1.LogicaDeNegocio.Servicios.ObtenerServiciosPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CasoPractico1.Controllers
{

    [Authorize(Roles = "Administrador")]
    public class ServiciosController : Controller
    {



        private IListarServiciosLN _listarServicios;
        private ICrearServiciosLN _crearServicios;
        IObtenerServiciosPorIdLN _obtenerServiciosPorId;
        IActualizarServiciosLN _actualizarServicios;
        IListarCitasLN _listarCitas;


      
        public ServiciosController()
        {
            _listarServicios = new ListarServiciosLN();
            _crearServicios = new CrearServiciosLN();
            _obtenerServiciosPorId = new ObtenerServiciosPorIdLN();
            _actualizarServicios = new ActualizarServiciosLN();
            _listarCitas = new ListarCitasLN();

        }





        public ActionResult ListarCitas(int id)
        {
            List<CitasDTO> laListaDeCitas = _listarCitas.Obtener(id);
            return View(laListaDeCitas);


        }

        // GET: Servicios
        public ActionResult ListarServicios()
        {
            List<ServiciosDTO> laListaDeServicios = _listarServicios.Obtener();
          
            return View(laListaDeServicios);
        }

        // GET: Servicios/Details/5
        public ActionResult DetallesServicios(int id)
        {
            ServiciosDTO elServicios = _obtenerServiciosPorId.Obtener(id);
            return View(elServicios);
        }


        // GET: Servicios/Create
        public ActionResult CrearServicios()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        public async Task<ActionResult> CrearServicios(ServiciosDTO elServiciosCreado)
        {
            try
            {

                int cantidadDeRegistros = await _crearServicios.Guardar(elServiciosCreado);



                return RedirectToAction("ListarServicios");
            }
            catch
            {
                return View();
            }
        }

        // GET: Servicios/Edit/5
        public ActionResult EditarServicios(int id)
        {
            ServiciosDTO elServicios= _obtenerServiciosPorId.Obtener(id);
            return View(elServicios);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult EditarServicios(ServiciosDTO elServiciosCreado)
        {
            try
            {
                int cantidadDeRegistros = _actualizarServicios.Actualizar(elServiciosCreado);
                return RedirectToAction("ListarServicios");
            }
            catch
            {
                return View(elServiciosCreado);
            }
        }

        // GET: Servicios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Servicios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
