﻿using SulikashviliPr16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SulikashviliPr16
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        internal Friend Model { get; private set; }
        internal ApplicationViewModel ViewModel { get; private set; }
        internal FriendPage(Friend model, ApplicationViewModel viewModel)
        {
            InitializeComponent();
            Model = model;
            ViewModel = viewModel;
            this.BindingContext = this;
        }
    }
}