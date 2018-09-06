using Fidelizando.Models;
using Fidelizando.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Fidelizando.Service
{
    public class MenuService
    {
        private static ObservableCollection<Fidelizando.Models.Menu> menuLista { get; set; }

        public static ObservableCollection<Fidelizando.Models.Menu> GetMenuItens()
        {
            menuLista = new ObservableCollection<Fidelizando.Models.Menu>();

            var pagina1 = new Fidelizando.Models.Menu() { Titulo = "Inicio", Icone = "casa.png", TargetType = typeof(HomePage) };
            var pagina2 = new Fidelizando.Models.Menu() { Titulo = "Meus Pontos", Icone = "estrela.png", TargetType = typeof(PontosPage) };
            //var pagina3 = new Fidelizando.Models.Menu() { Titulo = "Meus Dados", Icone = "dados1.png", TargetType = typeof(DadosPage) };
            var pagina4 = new Fidelizando.Models.Menu() { Titulo = "Cadastrar Pontos", Icone = "codigo.png", TargetType = typeof(CadastrarPage) };

            menuLista.Add(pagina1);
            menuLista.Add(pagina2);
           // menuLista.Add(pagina3);
            menuLista.Add(pagina4);

            return menuLista;
        }
    }
}
