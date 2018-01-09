﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace xBountyHunterShared.Views
{
    public class acercaDePage : ContentPage
    {
        Label ldevelopedby;
        Label ldevelopername;
        Label lyear;
        Label ltrainingsr;
        Label lratingvalor;
        Slider srating;
        StackLayout verticalStackLayout;

        public acercaDePage()
        {
            ldevelopedby = new Label
            {
                Text ="Desarollado por",
                FontSize =15,
                HorizontalTextAlignment = TextAlignment.Center
            };

            ldevelopername = new Label
            {
                Text = "Developer name here",
                FontSize = 12,
                HorizontalTextAlignment = TextAlignment.Center
            };

            lyear = new Label
            {
                Text = "2017",
                FontSize = 8,
                HorizontalTextAlignment = TextAlignment.Center
            };

            ltrainingsr = new Label
            {
                Text = "D.W. Training S.C.",
                FontSize = 12,
                HorizontalTextAlignment = TextAlignment.Center
            };

            lratingvalor = new Label
            {
                FontSize = 20,
                HorizontalTextAlignment = TextAlignment.Center
            };

            srating = new Slider
            {
                Maximum = 5,
                Minimum = 0,
                Value = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            verticalStackLayout = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            Title = "Acerca de";
            lratingvalor.Text = srating.Value.ToString();
            verticalStackLayout.Children.Add(ldevelopedby);
            verticalStackLayout.Children.Add(ldevelopername);
            verticalStackLayout.Children.Add(lyear);
            verticalStackLayout.Children.Add(ltrainingsr);
            verticalStackLayout.Children.Add(srating);
            verticalStackLayout.Children.Add(lratingvalor);

            srating.ValueChanged += (object sender, ValueChangedEventArgs e) =>
            {
                double value = srating.Value;
                value = Math.Round(value * 2) / 2;
                lratingvalor.Text = value.ToString();
            };

            Content = verticalStackLayout;
        }
        
    }
}