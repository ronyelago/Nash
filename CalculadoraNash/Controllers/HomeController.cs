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

        public ActionResult Calcular(PacienteViewModel pacienteViewModel)
        {
            var pacienteView = Mapper.Map<PacienteViewModel, Paciente>(pacienteViewModel);

            IndiceApri indiceApri = new IndiceApri(pacienteView);
            IndiceBard indiceBard = new IndiceBard(pacienteView);
            IndiceFib4 indiceFib4 = new IndiceFib4(pacienteView);
            IndiceNafld indiceNafld = new IndiceNafld(pacienteView);

            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceApri);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceBard);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceFib4);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceNafld);

            return View("Calculadora", pacienteViewModel);
        }

        public ActionResult CalcularDoBanco(PacienteViewModel pacienteViewModel)
        {
            CalculadoraContext context = new CalculadoraContext();
            var Paciente = context.Pacientes.FirstOrDefault(p => p.Id == 1);
            pacienteViewModel = Mapper.Map<Paciente, PacienteViewModel>(Paciente);


            return View("Paciente", pacienteViewModel);
        }
    }
}