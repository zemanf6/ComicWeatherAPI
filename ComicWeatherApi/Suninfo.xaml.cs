﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ComicWeatherApi
{
    /// <summary>
    /// Interakční logika pro Suninfo.xaml
    /// </summary>
    public partial class Suninfo : Window
    {
        public Suninfo()
        {
            InitializeComponent();
        }

        private async void LoadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();

            SunriseText.Text = $"Sunrise is at {sunInfo.Sunrise.ToLocalTime().ToShortTimeString()}";
            SunsetText.Text = $"Sunset is at {sunInfo.Sunset.ToLocalTime().ToShortTimeString()}";
        }
    }
}
