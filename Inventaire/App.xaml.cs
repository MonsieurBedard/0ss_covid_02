using BillingManagement.UI.ViewModels;
using BillingManagement.UI.Views;
using System.Windows;

namespace Inventaire
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainView _window;
        //InvoiceView _invoiceWindow;

        public App()
        {
            CustomerViewModel vm = new CustomerViewModel();
            _window = new MainView(vm);

            //InvoiceViewModel invoiceViewModel = new InvoiceViewModel();
            //_invoiceWindow = new InvoiceView(invoiceViewModel);

            _window.Show();
        }
    }
}
