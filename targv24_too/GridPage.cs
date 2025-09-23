﻿using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targv24_too;

public partial class GridPage : ContentPage
{
    Grid grid;

    public GridPage()
    {
        BackgroundColor = Color.FromRgb(120, 30, 50);
        grid = new Grid
        {
            BackgroundColor = Color.FromRgb(200, 200, 100),
            RowDefinitions =
                {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
            ColumnDefinitions =
                {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                }
        };
        for (int rida = 0; rida < 3; rida++)
        {
            for (int veerg = 0; veerg < 3; veerg++)
            {
                box = new BoxView { Color=Colors.AliceBlue, CornerRadius=20, Margin=5};
                grid.Add(box, veerg, rida);
                TapGestureRecognizer Tap = new TapGestureRecognizer();
                Tap.Tapped += Tap_Tapped;
                box.GestureRecognizers.Add(Tap);
                
            }
        }
        Content = grid;
    }

    private void Tap_Tapped(object? sender, TappedEventArgs e)
    {
        var box = (BoxView)sender;
        var r = Grid.GetRow(box);
        var v = Grid.GetColumn(box);
        //DisplayAlert("Info", $"Rida {r + 1}, veerg {v + 1}", "OK");
        box.Color = Colors.DarkBlue;
    }

}

