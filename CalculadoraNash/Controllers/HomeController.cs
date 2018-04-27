using CalculadoraNash.Models;
using System.Web.Mvc;
using AutoMapper;
using CalculadoraNash.Dominio.Servicos;
using CalculadoraNash.ViewModels;

namespace CalculadoraNash.Controllers
{
    public class HomeController : Controller
    {
        private readonly CalculoDeIndiceService _calculoDeIndiceService = new CalculoDeIndiceService();

        public ActionResult Calculadora(PacienteViewModel pacienteViewModel)
        {
            var viewModel = new CalculadoraViewModel()
            {
                Paciente = pacienteViewModel
            };
            return View(viewModel);
        }

        public ActionResult Calcular(CalculadoraViewModel calculadoraViewModel)
        {
            //TODO: validar entrada de dados
            
            var paciente = Mapper.Map<PacienteViewModel, Paciente>(calculadoraViewModel.Paciente);

            //Calculando índices
            var resultados = _calculoDeIndiceService.CalcularTodosOsIndices(paciente);

            //Montando viewModel para exibição na tela
            foreach (var resultadoCalculo in resultados)
            {
                var resultadoViewModel = new ResultadoCalculoViewModel(resultadoCalculo.NomeIndice, resultadoCalculo.Score);
                calculadoraViewModel.Resultados.Add(resultadoViewModel);
            }
            
            return View("Calculadora", calculadoraViewModel);
        }
    }
}