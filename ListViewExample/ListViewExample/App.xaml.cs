﻿using ListViewExample.Services;
using ListViewExample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new MainPage());
        
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
