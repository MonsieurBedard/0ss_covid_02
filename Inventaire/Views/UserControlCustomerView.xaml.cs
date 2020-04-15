using app_models;
using BillingManagement.UI.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BillingManagement.UI.Views
{
    /// <summary>
    /// Logique d'interaction pour UserControlCustomerView.xaml
    /// </summary>
    public partial class UserControlCustomerView : UserControl
    {
        CustomerViewModel _vm;

        public UserControlCustomerView(CustomerViewModel vm)
        {
            InitializeComponent();

            _vm = vm;
            DataContext = _vm;
        }

        private void CustomerNew_Click(object sender, RoutedEventArgs e)
        {
            Customer temp = new Customer() { Name = "Undefined", LastName = "Undefined" };
            _vm.Customers.Add(temp);
            _vm.SelectedCustomer = temp;
        }

        private void CustomerDelete_Click(object sender, RoutedEventArgs e)
        {
            int currentIndex = _vm.Customers.IndexOf(_vm.SelectedCustomer);

            if (currentIndex > 0)
                currentIndex--;

            _vm.Customers.Remove(_vm.SelectedCustomer);

            lvCustomers.SelectedIndex = currentIndex;

        }
    }
}
