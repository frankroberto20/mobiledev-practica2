using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Login.Models;
using Xamarin.Forms;

namespace Login.ViewModels
{
    class SignUpViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public UserOption User { get; set; } = new UserOption();
        public ICommand SignUpCommand { private set; get; }

        public async void OnSignUp()
        {
            if (string.IsNullOrEmpty(User.Username) || string.IsNullOrEmpty(User.Password) || string.IsNullOrEmpty(User.PasswordConfirm) || string.IsNullOrEmpty(User.FullName))
            {
                await App.Current.MainPage.DisplayAlert("Error", "Fields can't be empty", "OK");
            }
            else if (User.Password != User.PasswordConfirm)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Passwords don't match", "OK");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", $"Thanks for registering {User.FullName}", "OK");
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            }
        }

        public SignUpViewModel()
        {
            SignUpCommand = new Command(OnSignUp);
        }
    }
}
