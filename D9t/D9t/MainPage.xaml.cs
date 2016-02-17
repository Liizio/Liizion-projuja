﻿
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        int Cookie = 1190;
        int Mummoprice = 10;
        int Mummo = 0;
        int Farmiprice = 1200;
        int Farmi = 0;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "Keksejä: " + Cookie + "\nMummon hinta: " + Mummoprice + "\nFarmin hinta: " + Farmiprice;
            Cookie++;
            Cookie = Cookie + Mummo + (Farmi * 100);
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Cookie >= Mummoprice)
            {

                Cookie = Cookie - Mummoprice;
                Mummo++;
                mummobox.Text = Mummo.ToString();
                Mummoprice = (Mummoprice + 2);
                textBox.Text = "Keksejä: " + Cookie + "\nMummon hinta: " + Mummoprice + "\nFarmin hinta: " + Farmiprice;
            }
        }

        private void farmibutton_Click_1(object sender, RoutedEventArgs e)
        {
            if (Cookie >= Farmiprice)
            {

                Cookie = Cookie - Farmiprice;
                Farmi++;
                farmibox.Text = Farmi.ToString();
                Farmiprice = (Farmiprice * 2);
                textBox.Text = "Keksejä: " + Cookie + "\nMummon hinta: " + Mummoprice + "\nFarmin hinta: " + Farmiprice;
            }
        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}