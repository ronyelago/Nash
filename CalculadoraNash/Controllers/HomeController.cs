using CalculadoraNash.Models;
using System.Web.Mvc;
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
            
            //TODO: passar de pacienteviewmodel para Paciente (usar o automapper)
            var paciente = new Paciente() { Albumina = 1, ALT = 1, AST = 1, Diabetico = true, Idade = 80, IMC = 123, Nome = "Zé", Plaquetas = 12322};

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

        //public ActionResult Calcular(PacienteViewModel pacienteViewModel)
        //{
        //    pacienteViewModel.Indices.Add(new IndiceViewModel
        //    {
        //        Nome = "FIB-4",
        //        Score = IndiceViewModel.CalculaFib4(pacienteViewModel.DadosPaciente),
        //        Observacao = "Nada."
        //    });

        //    pacienteViewModel.Indices.Add(new IndiceViewModel
        //    {
        //        Nome = "BARD",
        //        Score = IndiceViewModel.CalculaBard(pacienteViewModel.DadosPaciente),
        //        Observacao = "Nada."
        //    });

        //    pacienteViewModel.Indices.Add(new IndiceViewModel
        //    {
        //        Nome = "NAFLD FIBROSIS",
        //        Score = IndiceViewModel.CalculaNafld(pacienteViewModel.DadosPaciente),
        //        Observacao = "Nada."
        //    });

        //    pacienteViewModel.Indices.Add(new IndiceViewModel
        //    {
        //        Nome = "APRI",
        //        Score = IndiceViewModel.CalculaApri(pacienteViewModel.DadosPaciente),
        //        Observacao = "nada."
        //    });

        //    return View("Calculadora", pacienteViewModel);
        //}

    }
}