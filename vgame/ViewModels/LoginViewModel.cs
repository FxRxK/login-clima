using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using Xamarin.Forms;

namespace vgame.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
    using Xamarin.Forms;
    
    public class LoginViewModel
    {
        public string password
        {
            get;
            set;
        }
    
        public string Email
        {
            get;
            set;
        }
        public bool IsRunning
        {
            get;
            set;
        }
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert("error",
                   "ingresa correo",
                   "ok");
                    return;
            }
            if (this.Email != "123@gmail.com" || this.password != "123")
            {
                await Application.Current.MainPage.DisplayAlert("error",
                   "ingresa correo 123@gmail.com y la contrasena 123",
                   "ok");
                return;
            }

            
               
            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage()); 
        }
    }
}
