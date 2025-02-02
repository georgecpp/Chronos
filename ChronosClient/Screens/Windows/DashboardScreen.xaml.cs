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
using ChronosClient.Screens.Pages;

namespace ChronosClient.Screens.Windows
{
    /// <summary>
    /// Interaction logic for DashboardScreen.xaml
    /// </summary>
    public partial class DashboardScreen : Window
    {
        public DashboardScreen()
        {
            InitializeComponent();
            dashboardFrame.Content = new DashboardHomeScreen();
        }

        private void new_plan_button_Click(object sender, RoutedEventArgs e)
        {
            NewPlanScreen planScreen = new NewPlanScreen();
            planScreen.ShowDialog();
        }
    }
}
