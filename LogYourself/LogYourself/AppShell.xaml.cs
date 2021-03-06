﻿
using LogYourself.ViewModels;
using LogYourself.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace LogYourself
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(SubstancePage), typeof(SubstancePage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
