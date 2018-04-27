using System.Web.Mvc;
using CalculadoraNash.ViewModels;
using CalculadoraNash.Dominio.Services;
using CalculadoraNash.Dominio.Entities.Indices;
using CalculadoraNash.Dominio.Entities;
using System;

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
            Paciente paciente = new Paciente
            {
                PacienteDados = new PacienteDados
                {
                    AST = pacienteViewModel.PacienteDados.AST,
                    ALT = pacienteViewModel.PacienteDados.ALT,
                    Idade = pacienteViewModel.PacienteDados.Idade,
                    IMC = pacienteViewModel.PacienteDados.IMC,
                    Albumina = pacienteViewModel.PacienteDados.Albumina,
                    Diabetico = pacienteViewModel.PacienteDados.Diabetico,
                    Plaquetas = pacienteViewModel.PacienteDados.Plaquetas,
                    DataAfericao = DateTime.Now
                }
            };

            IndiceApri indiceApri = new IndiceApri(paciente);
            IndiceBard indiceBard = new IndiceBard(paciente);
            IndiceFib4 indiceFib4 = new IndiceFib4(paciente);
            IndiceNafld indiceNafld = new IndiceNafld(paciente);

            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceApri);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceBard);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceFib4);
            pacienteViewModel.PacienteDados.ListaIndices.Add(indiceNafld);

            return View("Calculadora", pacienteViewModel);
        }
    }
}