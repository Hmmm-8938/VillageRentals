﻿namespace Village_Rentals_Application
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new VillageRentalsMenu());
        }
    }
}
