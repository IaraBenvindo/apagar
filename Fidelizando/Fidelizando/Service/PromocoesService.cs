using Fidelizando.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fidelizando.Service
{
    public class PromocoesService
    {
        private List<Promocoes> promocoes = new List<Promocoes>
        {
            new Promocoes {Nome="Produto 1", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 2", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 3", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 4", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 5", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 6", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 7", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 8", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 9", Pontos="10 Pontos", ImagemUrl="promo1.png"},
            new Promocoes {Nome="Produto 10", Pontos="10 Pontos", ImagemUrl="promo1.png"}
            };

        public IEnumerable<Promocoes> GetPromocoes()
        {
            return promocoes;
        }
    }
}
