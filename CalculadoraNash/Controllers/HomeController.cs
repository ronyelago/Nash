﻿using AutoMapper;
using CalculadoraNash.Application;
using CalculadoraNash.Application.Interfaces;
using CalculadoraNash.Domain.Entities;
using CalculadoraNash.Domain.Entities.Indices;
using CalculadoraNash.Domain.Interfaces.Services;
using CalculadoraNash.Domain.Services;
using CalculadoraNash.Infra.Data.Repositories;
using CalculadoraNash.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace CalculadoraNash.Controllers
{
    public class HomeController : Controller
    {
        private readonly PacienteRepository pacienteRepository = new PacienteRepository();
        //private readonly IPacienteAppService _pacienteAppService;

        //Resolver com injeção de dependência
        //public HomeController(IPacienteAppService pacienteAppService)
        //{
        //    _pacienteAppService = pacienteAppService;
        //}

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
        public ActionResult Create(PacienteViewModel pacienteView)
        {
            var paciente = Mapper.Map<PacienteViewModel, Paciente>(pacienteView);
            var pacienteDados = Mapper.Map<PacienteDadosViewModel, PacienteDados>(pacienteView.PacienteDados);

            paciente.ListaPacienteDados.Add(pacienteDados);

            pacienteRepository.Add(paciente);

            return View();
        }
    }
}