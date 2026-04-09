using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.CrearCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarCitasPorCliente;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ListarServiciosCitas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Citas.ObtenerCitasPorId;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ActualizarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ListarServicios;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Servicios.ObtenerServiciosPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.LogicaDeNegocio.Citas;
using CasoPractico1.LogicaDeNegocio.Citas.CrearCitas;
using CasoPractico1.LogicaDeNegocio.Citas.ListarCitas;
using CasoPractico1.LogicaDeNegocio.Citas.ListarCitasPorCliente;
using CasoPractico1.LogicaDeNegocio.Citas.ListarServiciosCitas;
using CasoPractico1.LogicaDeNegocio.Servicios.ListarServicios;
using CasoPractico1.LogicaDeNegocio.Servicios.ObtenerServiciosPorId;

namespace CasoPractico1.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class CitasController : Controller
    {
        private IListarServiciosCitasLN _listarServiciosCitas;
        private ICrearCitasLN _crearCitas;
        private IObtenerServiciosPorIdLN _obtenerServiciosPorId;
        private IListarCitasLN _listarCitas;
        private IObtenerCitasPorIdLN _obtenerCitasPorId;
        private IListarCitasPorClienteLN _listarCitasPorCliente;

        public CitasController()
        {
            _listarServiciosCitas = new ListarServiciosCitasLN();
            _crearCitas = new CrearCitasLN();
            _obtenerServiciosPorId = new ObtenerServiciosPorIdLN();
            _listarCitas = new ListarCitasLN();
            _obtenerCitasPorId = new ObtenerCitasPorIdLN();
            _listarCitasPorCliente = new ListarCitasPorClienteLN();
        }



        public ActionResult DetallesCitas(int id, string mensaje )
        {
            var laCita = _obtenerCitasPorId.Obtener(id);

            if (laCita == null)
            {
                return RedirectToAction("ListarServiciosCitas", new { mensaje = "“Estimado usuario, no se ha encontrado la cita, favor realice una" });
            }

            return View(laCita);
        }



        public ActionResult ListarServiciosCitas(string mensaje)
        {
           
            ViewBag.MensajeError = mensaje;

            List<ServiciosDTO> laListaDeServiciosCitas = _listarServiciosCitas.Obtener();

            return View(laListaDeServiciosCitas);
        }

        // GET: Citas/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Citas/Create
       
        public ActionResult CrearCitas(int id)
        {

            return View();
        }


        // POST: Clientes/Create
        [HttpPost]
        public async Task<ActionResult> CrearCitas(int id, CitasDTO lasCitasCreadas)
        {
            try
            {

                ServiciosDTO elServicio = _obtenerServiciosPorId.Obtener(id);
                lasCitasCreadas.IdServicio = id;
                lasCitasCreadas.MontoTotal = elServicio.Monto * (elServicio.IVA / 100) + elServicio.Monto;
                int cita = await _crearCitas.Guardar(lasCitasCreadas);
                return RedirectToAction("ListarServiciosCitas");
            }
            catch
            {
                return View();
            }
        }

        // GET: Citas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Citas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Citas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Citas/Delete/5
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

        // GET: Citas/CitasPorCliente
        public ActionResult CitasPorCliente()
        {
            return View();
        }

        // POST: Citas/CitasPorCliente
        [HttpPost]
        public ActionResult CitasPorCliente(string identificacion)
        {
            if (string.IsNullOrEmpty(identificacion))
            {
                ViewBag.Mensaje = "Por favor ingrese una identificación válida";
                return View();
            }

            List<CitasDTO> laListaDeCitas = _listarCitasPorCliente.ObtenerPorIdentificacion(identificacion);
            
            if (laListaDeCitas == null || laListaDeCitas.Count == 0)
            {
                ViewBag.Mensaje = "No se encontraron citas para la identificación ingresada";
                return View();
            }

            ViewBag.Identificacion = identificacion;
            ViewBag.NombreCliente = laListaDeCitas.First().NombreDeLaPersona;
            return View(laListaDeCitas);
        }
    }
}
