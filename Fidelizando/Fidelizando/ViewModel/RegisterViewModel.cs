using Fidelizando.Helpers;
using Fidelizando.Models;
using Fidelizando.Pages;
using Fidelizando.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Fidelizando.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        public ICommand RegisterCommand { get; set; }

        private Usuario _user;
        public Usuario User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }

        private string _erro;
        public string Erro
        {
            get
            {
                return _erro;
            }

            set
            {
                _erro = value;
                NotifyPropertyChanged("Erro");
            }
        }

        public RegisterViewModel()
        {
            this.RegisterCommand = new Command(Register);
            User = new Usuario();
        }

        private void Register()
        {
            try
            {
                UsuarioService.Insert(User);
                Settings.Email = User.Email;
                Settings.Name = User.Nome;
                App.Current.MainPage = new IndexPage();
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
            }
        }
    }
}
