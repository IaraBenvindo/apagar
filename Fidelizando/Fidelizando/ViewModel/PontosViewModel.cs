using Fidelizando.Helpers;
using Fidelizando.Models;
using Fidelizando.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fidelizando.ViewModel
{
    public class PontosViewModel : BaseViewModel
    {
        public ICommand ScanearCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand AdicionarPontosCommand { get; set; }

        private Usuario _usuario;
        public Usuario Usuario
        {
            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value;
                NotifyPropertyChanged("Usuario");
            }
        }

        public PontosViewModel()
        {
            //this.LogoutCommand = new Command(LogOut);
            // this.ScanearCommand = new Command(Scanear);
            this.AdicionarPontosCommand = new Command(AdicionarPontos);
            PegarUsuario();
        }

        private void AdicionarPontos()
        {
            UsuarioService.AdicionarPontos(Settings.Email);
            PegarUsuario();
        }

        private void PegarUsuario()
        {
            Usuario = new Usuario()
            {
                Email = Settings.Email,
                Nome = Settings.Name,
                Pontos = UsuarioService.PegarPontos(Settings.Email)
            };
        }
    }
}
