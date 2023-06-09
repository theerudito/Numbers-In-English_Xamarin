﻿using Microsoft.EntityFrameworkCore;
using NumbersInEnglish.ApplicationContextDB;
using NumbersInEnglish.Helpers;
using NumbersInEnglish.Views;
using Xamarin.Forms;

namespace NumbersInEnglish
{
    public partial class App : Application
    {
        public App()
        {
            LocalStorange.SetLocalStorange("theme", "Dark");

            var _dbCcontext = new ApplicationContext_DB();

            _dbCcontext.Database.Migrate();

            var query = _dbCcontext.Number.Find(1);

            if (query == null)
            {
                InformationData.DataDefault();
            }

            InitializeComponent();

            MainPage = new NavigationPage(new Page_Home());
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