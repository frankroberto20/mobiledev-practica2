using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static readonly BindableProperty MenuTitleProperty = BindableProperty.Create(
            "MenuTitle",        // the name of the bindable property
            typeof(string),     // the bindable property type
            typeof(MenuView),   // the parent object type
            string.Empty);      // the default value for the property

        public static readonly BindableProperty MenuIconSourceProperty = BindableProperty.Create(
            "MenuIconSource",        // the name of the bindable property
            typeof(string),     // the bindable property type
            typeof(MenuView),   // the parent object type
            string.Empty);      // the default value for the property

        public static readonly BindableProperty MenuDescriptionProperty = BindableProperty.Create(
            "MenuDescription",        // the name of the bindable property
            typeof(string),     // the bindable property type
            typeof(MenuView),   // the parent object type
            string.Empty);      // the default value for the property

        public string MenuTitle
        {
            get => (string)GetValue(MenuTitleProperty);
            set => SetValue(MenuTitleProperty, value);
        }

        public string MenuIconSource
        {
            get => (string)GetValue(MenuIconSourceProperty);
            set => SetValue(MenuIconSourceProperty, value);
        }

        public string MenuDescription
        {
            get => (string)GetValue(MenuDescriptionProperty);
            set => SetValue(MenuDescriptionProperty, value);
        }
    }
}