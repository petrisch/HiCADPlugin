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


namespace PluginTemplate
{
    /// <summary>
    /// Interaktionslogik für Plugininterface.xaml
    /// </summary>
    public partial class Plugininterface : UserControl
    {
        public Plugininterface()
        {
            InitializeComponent();
            
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        public void HelloMessageButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hi Patrick jpc");
        }
    }
}