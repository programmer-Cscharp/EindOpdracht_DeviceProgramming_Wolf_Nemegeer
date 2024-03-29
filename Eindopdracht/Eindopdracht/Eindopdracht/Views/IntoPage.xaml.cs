﻿using Eindopdracht.Models;
using Eindopdracht.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Eindopdracht.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntoPage : ContentPage
    {
        Book book { get; set; }

        public IntoPage(Book pbook)
        {

            InitializeComponent();
            Network.NetworkControle();
            book = pbook;
            Browser.Source = book.Text_Url;
            TapGestureRecognizer recognizer = new TapGestureRecognizer();
            recognizer.Tapped += Recognizer_Tapped;
            imgBack.GestureRecognizers.Add(recognizer);
            imgBack.Source = ImageSource.FromResource("Eindopdracht.Assets.baseline_arrow_back_white_24dp.png");

        }

        private void Recognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}