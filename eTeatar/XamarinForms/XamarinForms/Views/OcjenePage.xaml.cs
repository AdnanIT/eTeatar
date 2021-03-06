﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.ViewModels;

namespace XamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OcjenePage : TabbedPage
    {
        OcjeneViewModel model;
        public OcjenePage()
        {
            InitializeComponent();
            BindingContext = model = new OcjeneViewModel(Navigation);
        }

        protected override void OnAppearing()
        {
            model.Init.Execute(null);
            base.OnAppearing();
        }
    }
}