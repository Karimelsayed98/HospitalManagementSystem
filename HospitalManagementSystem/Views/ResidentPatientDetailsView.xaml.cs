﻿using HospitalManagementSystem.ViewModels;
using System;
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

namespace HospitalManagementSystem.Views
{
    /// <summary>
    /// Interaction logic for ResidentPatientDetailsView.xaml
    /// </summary>
    public partial class ResidentPatientDetailsView : UserControl
    {
        public ResidentPatientDetailsViewModel ViewModel { get; set; }
        public ResidentPatientDetailsView()
        {
            InitializeComponent();
           
        }
        private void DeleteResidentPatient(object sender, MouseButtonEventArgs e)
        {
            ViewModel.DeleteResidentPatient();
        }

        private void EditResidentPatient(object sender, RoutedEventArgs e)
        {
            ViewModel.EditResidentPatient();
            Home.ViewModel.CloseRootDialog();
        }
    }
}
