using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ActualizarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.CrearClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.EliminarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ListarClinicas;
using CasoPractico1.Abstracciones.LogicaDeNegocio.Clinicas.ObtenerClinicasPorId;
using CasoPractico1.Abstracciones.ModelosParaUI;
using CasoPractico1.LogicaDeNegocio.Clinicas.ActualizarClinicas;
using CasoPractico1.LogicaDeNegocio.Clinicas.CrearClinicas;
using CasoPractico1.LogicaDeNegocio.Clinicas.EliminarClinicas;
using CasoPractico1.LogicaDeNegocio.Clinicas.ListarClinicas;
using CasoPractico1.LogicaDeNegocio.Clinicas.ObtenerClinicasPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CasoPractico1.Controllers
{
    public class ClinicasController : Controller
    {
        private IListarClinicasLN _listarClinicas;
        private ICrearClinicasLN _crearClinicas;
        private IObtenerClinicasPorIdLN _obtenerClinicasPorId;
        private IActualizarClinicasLN _actualizarClinicas;
        private IEliminarClinicasLN _eliminarClinicas;

        public ClinicasController()
        {
            _listarClinicas = new ListarClinicasLN();
            _crearClinicas = new CrearClinicasLN();
            _obtenerClinicasPorId = new ObtenerClinicasPorIdLN();
            _actualizarClinicas = new ActualizarClinicasLN();
            _eliminarClinicas = new EliminarClinicasLN();
        }

        // GET: Clinicas
        public ActionResult ListarClinicas()
        {
            List<ClinicasDTO> laListaDeClinicas = _listarClinicas.Obtener();
            return View(laListaDeClinicas);
        }

        // GET: Clinicas/Details/5
        public ActionResult DetallesClinicas(int id)
        {
            ClinicasDTO laClinica = _obtenerClinicasPorId.Obtener(id);
            return View(laClinica);
        }

        // GET: Clinicas/Create
        public ActionResult CrearClinicas()
        {
            return View();
        }

        // POST: Clinicas/Create
        [HttpPost]
        public async Task<ActionResult> CrearClinicas(ClinicasDTO laClinicaCreada)
        {
            try
            {
                int cantidadDeRegistros = await _crearClinicas.Guardar(laClinicaCreada);
                return RedirectToAction("ListarClinicas");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clinicas/Edit/5
        public ActionResult EditarClinicas(int id)
        {
            ClinicasDTO laClinica = _obtenerClinicasPorId.Obtener(id);
            return View(laClinica);
        }

        // POST: Clinicas/Edit/5
        [HttpPost]
        public ActionResult EditarClinicas(ClinicasDTO laClinicaEditada)
        {
            try
            {
                int cantidadDeRegistros = _actualizarClinicas.Actualizar(laClinicaEditada);
                return RedirectToAction("ListarClinicas");
            }
            catch
            {
                return View(laClinicaEditada);
            }
        }

        // GET: Clinicas/Delete/5
        public ActionResult EliminarClinicas(int id)
        {
            ClinicasDTO laClinica = _obtenerClinicasPorId.Obtener(id);
            return View(laClinica);
        }

        // POST: Clinicas/Delete/5
        [HttpPost]
        public ActionResult EliminarClinicasConfirmado(int id)
        {
            try
            {
                int cantidadDeRegistros = _eliminarClinicas.Eliminar(id);
                return RedirectToAction("ListarClinicas");
            }
            catch
            {
                return View();
            }
        }
    }
}
