using AutoMapper;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.Dominio.Entities.Indices;
using CalculadoraNash.Dominio.Mappings;
using CalculadoraNash.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace CalculadoraNash.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalculadoraContext context = new CalculadoraContext();

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
            if (!ModelState.IsValid)
            {
                return View("Calculadora", pacienteViewModel);
            }

            Paciente pacienteView = Mapper.Map<PacienteViewModel, Paciente>(pacienteViewModel);
            pacienteView.ListaPacienteDados.Add(Mapper.Map<PacienteDadosViewModel, PacienteDados>(pacienteViewModel.PacienteDados));
            
            IndiceApri indiceApri = new IndiceApri(pacienteView.ListaPacienteDados.FirstOrDefault());
            IndiceBard indiceBard = new IndiceBard(pacienteView.ListaPacienteDados.FirstOrDefault());
            IndiceFib4 indiceFib4 = new IndiceFib4(pacienteView.ListaPacienteDados.FirstOrDefault());
            IndiceNafld indiceNafld = new IndiceNafld(pacienteView.ListaPacienteDados.FirstOrDefault());

            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceApri);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceBard);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceFib4);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceNafld);

            pacienteViewModel.Calculado = true;

            return View("Calculadora", pacienteViewModel);
        }

        [HttpPost]
        public ActionResult Create(PacienteViewModel paciente)
        {
            var p = Mapper.Map<PacienteViewModel, Paciente>(paciente);
            var pd = Mapper.Map<PacienteDadosViewModel, PacienteDados>(paciente.PacienteDados);
            pd.DataAfericao = DateTime.Now;

            p.ListaPacienteDados.Add(pd);

            context.Pacientes.Add(p);
            context.SaveChanges();

            return View();
        }
    }
}