using System;
using CalculadoraNash.Dominio.ValueObject;
using CalculadoraNash.Models;
using System.Collections.Generic;
using System.Linq;
using CalculadoraNash.Dominio.Entidades.Indices;

namespace CalculadoraNash.Dominio.Servicos
{
    public class CalculoDeIndiceService
    {
        private readonly IIndice[] TodosOsIndices = {
            new IndiceApri(),
            new IndiceBard(),
            new IndiceFib4(),
            new IndiceNafld()
        };

        public double CalculaIndice(string nomeIndice, Paciente paciente)
        {
            var indice = TodosOsIndices.FirstOrDefault(a => a.Nome == nomeIndice);
            if(indice == null)
                throw new Exception($"Indice não encontrado ({nomeIndice})");

            return indice.Score(paciente);
        }

        public IEnumerable<ResultadoCalculo> CalcularTodosOsIndices(Paciente paciente)
        {
            var listaResultados = new List<ResultadoCalculo>();

            foreach (var indice in TodosOsIndices)
            {
                listaResultados.Add(new ResultadoCalculo(indice.Nome, indice.Score(paciente)));
            }

            return listaResultados;
        }
    }
}
