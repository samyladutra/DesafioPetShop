using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Petshop.Models;

namespace Petshop.Controllers
{
    [Route("api/[controller]")]
    public class GerenciamentoPetshop : Controller
    {
        List<Models.Petshop> listaPetShops = new List<Models.Petshop>();

        public GerenciamentoPetshop()
        {
            Models.Petshop meuCaninoFeliz = new Models.Petshop();
            meuCaninoFeliz.nomePetshop = "Meu Canino Feliz";
            meuCaninoFeliz.distancia = 2000;
            meuCaninoFeliz.vlDiasUteisCaesPequenos = 20;
            meuCaninoFeliz.vlDiasUteisCaesGrandes = 40;
            meuCaninoFeliz.vlFDSCaesPequenos = meuCaninoFeliz.vlDiasUteisCaesPequenos * 0.02 + meuCaninoFeliz.vlDiasUteisCaesPequenos;
            meuCaninoFeliz.vlFDSCaesGrandes = meuCaninoFeliz.vlDiasUteisCaesGrandes * 0.02 + meuCaninoFeliz.vlDiasUteisCaesGrandes;
            listaPetShops.Add(meuCaninoFeliz);

            Models.Petshop vaiRex = new Models.Petshop();
            vaiRex.nomePetshop = "Vai Rex";
            vaiRex.distancia = 1700;
            vaiRex.vlDiasUteisCaesPequenos = 15;
            vaiRex.vlDiasUteisCaesGrandes = 50;
            vaiRex.vlFDSCaesPequenos = 20;
            vaiRex.vlFDSCaesGrandes = 55;
            listaPetShops.Add(vaiRex);

            Models.Petshop chowChawgas = new Models.Petshop();
            chowChawgas.nomePetshop = "Chow Chawgas";
            chowChawgas.distancia = 800;
            chowChawgas.vlDiasUteisCaesPequenos = 30;
            chowChawgas.vlDiasUteisCaesGrandes = 45;
            chowChawgas.vlFDSCaesPequenos = meuCaninoFeliz.vlDiasUteisCaesPequenos;
            chowChawgas.vlFDSCaesGrandes = meuCaninoFeliz.vlDiasUteisCaesGrandes;
            listaPetShops.Add(chowChawgas);
        }

        public Models.Petshop ObterMelhorPetShop(DateTime data, int quantCaesPequenos, int quantCaesGrandes)
        {
            Models.Petshop petshop = new Models.Petshop();

            if (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday)
                petshop = CalcularPrecoFimSemana(quantCaesPequenos, quantCaesGrandes);
            else
                petshop = CalcularPrecoDiasUteis(quantCaesPequenos, quantCaesGrandes);

            return petshop;
        }

        private Models.Petshop CalcularPrecoFimSemana(int quantCaesPequenos, int quantCaesGrandes)
        {
            List<double> precos = new List<double>();
            int posicao = 0;
            foreach (var petshop in listaPetShops)
            {
                var preco = petshop.vlFDSCaesPequenos * quantCaesPequenos + petshop.vlFDSCaesGrandes * quantCaesGrandes;
                precos.Add(preco);
            }

            posicao = ObterIndexMenorPreco(precos);

            return listaPetShops[posicao];
        }

        private Models.Petshop CalcularPrecoDiasUteis(int quantCaesPequenos, int quantCaesGrandes)
        {
            List<double> precos = new List<double>();
            int posicao = 0;

            foreach (var petshop in listaPetShops)
            {
                var preco = petshop.vlDiasUteisCaesPequenos * quantCaesPequenos + petshop.vlDiasUteisCaesGrandes * quantCaesGrandes;
                precos.Add(preco);
            }

            posicao = ObterIndexMenorPreco(precos);

            return listaPetShops[posicao];
        }

        private int ObterIndexMenorPreco(List<double> precos)
        {
            int posicao = 0;
            //seleciona o menor preco
            double menorPreco = precos[0];
            for (int i = 1; i < precos.Count; i++)
            {
                if (precos[i] < menorPreco)
                {
                    menorPreco = precos[i];
                    posicao = i;
                }
                else if (precos[i] == menorPreco)
                {
                    //em caso de empate seleciona a menor distancia
                    posicao = EscolherMenorDistancia();
                }
            }
            return posicao;
        }

        private int EscolherMenorDistancia()
        {
            int index = 0;
            double menorDistancia = listaPetShops[0].distancia;
            for (int i = 1; i < listaPetShops.Count; i++)
            {
                if (listaPetShops[i].distancia < menorDistancia)
                {
                    menorDistancia = listaPetShops[i].distancia;
                    index = i;
                }
            }
            return index;
        }
    }
}
