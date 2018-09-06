using Fidelizando.Service;
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Fidelizando.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
    {
        private PromocoesService _service = new PromocoesService();

        public HomePage ()
		{
			InitializeComponent ();

            /* List<string> itens = new List<string>()
             {
                 "Promocoes1", "Promocoes2", "Promocoes3", "Promocoes4"
             };*/
            promocoes.ItemsSource = _service.GetPromocoes();

        }
	}
}