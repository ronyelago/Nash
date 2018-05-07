using AutoMapper;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.Dominio.Entities.Indices;
using CalculadoraNash.Dominio.Mappings;
using CalculadoraNash.Dominio.Services;
using CalculadoraNash.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CalculadoraNash.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalculoDeIndiceService _calculoDeIndiceService = new CalculoDeIndiceService();

        public ActionResult Calculadora(PacienteViewModel pacienteViewModel)
        {
            return View(pacienteViewModel);
        }

        [HttpGet]
        public ActionResult Calcular()
        {
            return View("Calculadora", new PacienteViewModel());
        }

        [HttpPost]
        public ActionResult Calcular(PacienteViewModel pacienteViewModel)
        {
            if(!ModelState.IsValid)
                return View("Calculadora", pacienteViewModel);

            var pacienteView = Mapper.Map<PacienteViewModel, Paciente>(pacienteViewModel);
            
            IndiceApri indiceApri = new IndiceApri(pacienteView);
            IndiceBard indiceBard = new IndiceBard(pacienteView);
            IndiceFib4 indiceFib4 = new IndiceFib4(pacienteView);
            IndiceNafld indiceNafld = new IndiceNafld(pacienteView);

            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceApri);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceBard);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceFib4);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceNafld);

            pacienteViewModel.Calculado = true;

            return View("Calculadora", pacienteViewModel);
        }

        public ActionResult CalcularDoBanco(PacienteViewModel pacienteViewModel)
        {
            CalculadoraContext context = new CalculadoraContext();

            var paciente = from p in context.Pacientes
                    where p.Id == 1
                    select p;



            return View("Paciente", pacienteViewModel);
        }

        public ActionResult Paciente()
        {
            return View();
        }
    }
}