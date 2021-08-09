﻿using MySql.Data.MySqlClient;
using PrototipoLaboratorio.Ventanas;
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

namespace PrototipoLaboratorio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = "SERVER=localhost;DATABASE=CLINICA;UID=root;PASSWORD=6182;";
            MySqlConnection connetion = new MySqlConnection(connectionString);
            MySqlCommand cmd = new MySqlCommand("select * from TIPO_USUARIO", connetion);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPersonal_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnGestionusuario_Click(object sender, RoutedEventArgs e){
            funGestorventas(new Ventanas.wpfGestorusuario());
        }
        private void btnTipousuario_Click(object sender, RoutedEventArgs e)
        {
            funGestorventas(new Ventanas.wpfTipousuario());
        }
        private void btnTipocambio_Click(object sender, RoutedEventArgs e)
        {
            funGestorventas(new Ventanas.wpfTipocambio());
        }

        private void funGestorventas(UserControl control)
        {
            this.pnlVentanas.Children.Clear();
            this.pnlVentanas.Children.Add(control);
        }


        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.pnlVentanas.Children.Clear();
        }
    }

}
