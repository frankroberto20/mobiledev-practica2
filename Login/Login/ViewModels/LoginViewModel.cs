using Login.Models;
using Login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Login.ViewModels
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public UserOption User { get; set; } = new UserOption();
        public ICommand LoginCommand { private set; get; }
        public ICommand SignUpNavigateCommand { private set; get; }

        public async void OnLogin()
        {
            if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "User and Password fields can't be empty", "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", $"Hello {User.Username}", "OK");
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
        }

        public async void SignUpNavigate()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
        
        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            SignUpNavigateCommand = new Command(SignUpNavigate);
        }
    }
}
