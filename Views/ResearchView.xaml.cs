﻿using System;
using System.Collections.Generic;
using System.Text;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace ex1.Views
{
    /// <summary>
    /// Interaction logic for ResearchView.xaml
    /// </summary>
    public partial class ResearchView : UserControl
    {
        private ResearchViewModel researchVM;
        internal ResearchViewModel ResearchVM
        {
            get
            {
                return researchVM;
            }
            set
            {
                researchVM = value;
            }
        }
        public ResearchView()
        {
            InitializeComponent();
            DataContext = researchVM;
        }
    }
}
