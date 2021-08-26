using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuView : ContentView
    {
        public MenuView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty MenuOptionProperty = BindableProperty.Create(
            "MenuOption",
            typeof(MenuOption),
            typeof(MenuView),
            new MenuOption());

        public MenuOption MenuOption
        {
            get => (MenuOption)GetValue(MenuOptionProperty);
            set => SetValue(MenuOptionProperty, value);
        }
    }
}