using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Login.Models;

namespace Login.ViewModels
{
    class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public MenuOption BarsAndHotelsMenuOption { get; set; }
        public MenuOption FineDiningMenuOption { get; set; }
        public MenuOption NearbyMenuOption { get; set; }
        public MenuOption CafesMenuOption { get; set; } 
        public MenuOption FastFoodsMenuOption { get; set; }
        public MenuOption FeaturedFoodsMenuOption { get; set; }

        public HomeViewModel()
        {
            BarsAndHotelsMenuOption = new MenuOption() { Title = "Bars & Hotels", Description = "Places 32", ImageSource = "HomeMenuIcon" };
            FineDiningMenuOption = new MenuOption() { Title = "Fine Dining", Description = "Places 21", ImageSource = "MusicMenuIcon" };
            NearbyMenuOption = new MenuOption() { Title = "Nearby", Description = "Places 10", ImageSource = "LocationMenuIcon" };
            CafesMenuOption = new MenuOption() { Title = "Cafes", Description = "Places 32", ImageSource = "HomeMenuIcon" };
            FastFoodsMenuOption = new MenuOption() { Title = "Fast Foods", Description = "Places 58", ImageSource = "FastMenuIcon" };
            FeaturedFoodsMenuOption = new MenuOption() { Title = "Featured Foods", Description = "Places 20", ImageSource = "StoreMenuIcon" };
        }

    }
}
