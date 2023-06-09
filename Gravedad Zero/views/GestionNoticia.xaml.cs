﻿using Gravedad_Zero.view_model;
using System.Windows.Controls;


namespace Gravedad_Zero.views
{
    /// <summary>
    /// Lógica de interacción para GestionNoticia.xaml
    /// </summary>
    public partial class GestionNoticia : UserControl
    {
        private GestionNoticiaVM vmGestionNoticia;
        public GestionNoticia()
        {
            InitializeComponent();
            vmGestionNoticia = new GestionNoticiaVM();
            this.DataContext = vmGestionNoticia;
        }
        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numeroCaracteresTextoTextBox.Text = textoTextBox.Text.Length.ToString() + "/280";
        }

        private void tituloTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            numeroCaracteresTituloTextBox.Text = tituloTextBox.Text.Length.ToString() + "/30";

        }
    }
}

