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

namespace CalculatorV2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //View.Page1 page1 = new View.Page1();
        //View.Window1 window1 = new View.Window1();
        //ViewModel.CalculatorViewModel calculatorViewModel = new ViewModel.CalculatorViewModel();
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ViewModel.CalculatorViewModel();
        }
    }
}
