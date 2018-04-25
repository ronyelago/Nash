using CalculadoraNash.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculadoraNash.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Calculadora(Paciente paciente)
        {
            return View(paciente);
        }

        public ActionResult Calcular(Paciente paciente)
        {
            paciente.Indices.Add(new Indice
            {
                Calculo = "FIB-4",
                Score = Indice.CalculaFib4(paciente.DadosPaciente),
                Observacao = "Nada."
            });

            paciente.Indices.Add(new Indice
            {
                Calculo = "BARD",
                Score = Indice.CalculaBard(paciente.DadosPaciente),
                Observacao = "Nada."
            });

            paciente.Indices.Add(new Indice
            {
                Calculo = "NAFLD FIBROSIS",
                Score = Indice.CalculaNafld(paciente.DadosPaciente),
                Observacao = "Nada."
            });

            paciente.Indices.Add(new Indice
            {
                Calculo = "APRI",
                Score = Indice.CalculaApri(paciente.DadosPaciente),
                Observacao = "nada."
            });

            return View("Calculadora", paciente);
        }

    }
}