using System;
using CalculadoraNash.Dominio.ValueObject;
using System.Linq;
using CalculadoraNash.Dominio.Entities;

namespace CalculadoraNash.Dominio.Services
{
    public class CalculoDeIndiceService
    {

        // Pesquisa e Retorna um índice especifico de um paciente.
        // O índice é pesquisado de acordo com o título.
        // Um paciente possui uma lista de índices.
        //public double CalculaIndice(int IndiceId, Paciente paciente)
        //{
        //    var indice = paciente.Indices.FirstOrDefault(i => i.Id == IndiceId);

        //    if(indice == null)
        //    {
        //        throw new Exception($"Indice não encontrado ({IndiceId})");
        //    }

        //    return indice.GetScore(paciente);
        //}

        //public IndiceFibrose CalcularIndiceFibrose(Paciente paciente)
        //{
        //    if (paciente.Indices.)
        //    {

        //    }


        //    return paciente.IndiceFibrose;
        //}
    }
}
