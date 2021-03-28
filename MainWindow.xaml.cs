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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ex1.ViewModels;
using ex1.Model;
using ex1.Views;

namespace ex1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FlightControl fc;
        public MainWindow()
        {
            fc = new FlightControl();
            ConfigWindow cw = new ConfigWindow(this, fc);
            cw.Show();
            InitializeComponent();

            PlayerViewModel pvm = new PlayerViewModel(fc); ;
            playerView.PlayerVM = pvm;
            playerView.DataContext = pvm;

            DataViewModel dvm = new DataViewModel(fc); ;
            dataView.DataVM = dvm;
            dataView.DataContext = dvm;

            ResearchViewModel rvm = new ResearchViewModel(fc); ;
            researchView.ResearchVM = rvm;
            researchView.DataContext = rvm;

            Visibility = Visibility.Hidden;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            fc.endClient();
        }
    }
}