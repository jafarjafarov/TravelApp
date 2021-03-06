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
using TravelApp.ViewModels;

namespace TravelApp.Views
{
    /// <summary>
    /// Interaction logic for ResetPasswordView.xaml
    /// </summary>
    /// 
    public partial class ResetPasswordView : UserControl
    {
        private ResetPasswordViewModel resetPasswordViewModel;


        public ResetPasswordView()
        {
            InitializeComponent();
            resetPasswordViewModel = new ResetPasswordViewModel();
            DataContext = resetPasswordViewModel;
        }
    }
}
