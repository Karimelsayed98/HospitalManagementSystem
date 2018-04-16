﻿using HospitalManagementSystem.Models;
using HospitalManagementSystem.ViewModels;
using HospitalManagementSystem.Views.Components;
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
    /// Interaction logic for EmployeesView.xaml
    /// </summary>
    public partial class EmployeesView : UserControl
    {
        public EmployeesViewModel ViewModel { get; set; }

        public EmployeesView()
        {
            ViewModel = new EmployeesViewModel();
            DataContext = ViewModel;
            InitializeComponent();
        }

        public void addEmployee(object sender, RoutedEventArgs e)
        {
            // TODO: Openning a Message Box with Add
            // TODO: Add to Hospital Class
            // TODO: Update DB
            ViewModel.Employees.Add(
                new EmployeeCardViewModel
                {
                    Name = "Name",
                    Role = "Role",
                    Department = "Department",
                    Salary = "3000.00$"
                }    
            );
        }
    }
}