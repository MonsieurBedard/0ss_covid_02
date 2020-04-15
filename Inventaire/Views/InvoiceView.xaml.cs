using BillingManagement.UI.ViewModels;
using Inventaire;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BillingManagement.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour InvoiceView.xaml
    /// </summary>
    public partial class InvoiceView : Window
    {
        InvoiceViewModel _vm;

        public InvoiceView(InvoiceViewModel vm)
        {
            InitializeComponent();

            _vm = vm;
            DataContext = _vm;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
