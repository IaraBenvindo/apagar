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
	public partial class CadastrarPage : ContentPage
	{
        public CadastrarPage ()
		{
			InitializeComponent ();
		}

        private async void Button_OnClicked(object sender, EventArgs e) => await OpenScan();

        private async Task OpenScan()
        {
            var scanner = DependencyService.Get<IQrCodeScanningService>();
            var result = await scanner.ScanAsync();
            if (!string.IsNullOrEmpty(result))
            {
                // Sua logica.
                var QrCode = result;
            }
        }
    }
}