﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Fitness_App.Services;
//using Fitness_App.Views;

namespace Fitness_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
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
