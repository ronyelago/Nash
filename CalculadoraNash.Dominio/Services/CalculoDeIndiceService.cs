using System;
using CalculadoraNash.Dominio.ValueObject;
using System.Collections.Generic;
using System.Linq;
using CalculadoraNash.Dominio.Entities;
using CalculadoraNash.Dominio.Entities.Indices;

namespace CalculadoraNash.Dominio.Services
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
            var indice = TodosOsIndices.FirstOrDefault(a => a.Titulo == nomeIndice);

            if(indice == null)
            {
                throw new Exception($"Indice não encontrado ({nomeIndice})");
            }
            
            return indice.GetScore(paciente);
        }

        public IEnumerable<ScoreFibrose> CalcularTodosOsIndices(Paciente paciente)
        {
            var listaResultados = new List<ScoreFibrose>();

            foreach (var indice in TodosOsIndices)
            {
                listaResultados.Add(new ScoreFibrose(indice.Titulo, indice.GetScore(paciente)));
            }

            return listaResultados;
        }
    }
}
