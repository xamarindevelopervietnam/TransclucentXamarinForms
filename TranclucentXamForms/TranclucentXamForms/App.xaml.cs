﻿using System;

using TranclucentXamForms.Views;
using Xamarin.Forms;

namespace TranclucentXamForms
{
	public partial class App : Application
	{

		public App ()
		{
			InitializeComponent();


            //MainPage = new NavigationPage(new Page{Title = "Test page with Translucent"});
            MainPage = new MasterDetailPage1();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
