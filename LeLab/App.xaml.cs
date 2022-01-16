﻿using System;
using LeLab.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LeLab
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CountPage();
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