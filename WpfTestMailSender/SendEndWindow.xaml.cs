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

namespace WpfTestMailSender
{
    /// <summary>
    /// Логика взаимодействия для SendEndWindow.xaml
    /// </summary>
    public partial class SendEndWindow : Window
    {
        private string result;

        public SendEndWindow(string str)
        {
            InitializeComponent();

            result = str;
            lblSendEnd.Content = result;
        }

        private void BtnOk_Click( object sender, RoutedEventArgs e )
        {
            Close();
        }
    }
}
