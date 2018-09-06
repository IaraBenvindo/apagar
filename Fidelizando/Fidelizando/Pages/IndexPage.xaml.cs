using Fidelizando.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fidelizando.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IndexPage : MasterDetailPage
	{
        private ObservableCollection<Fidelizando.Models.Menu> _menuLista;

		public IndexPage ()
		{
			InitializeComponent ();
            _menuLista = MenuService.GetMenuItens();
            NavigationDrawerList.ItemsSource = _menuLista;
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(HomePage)));
        }

        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = (Fidelizando.Models.Menu)e.SelectedItem;
            Type pagina = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(pagina));
            IsPresented = false;
        }

       
    }
}