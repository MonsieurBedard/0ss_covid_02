using BillingManagement.UI.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.UI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
		private BaseViewModel _vm;
		public BaseViewModel VM
		{
			get => _vm;
			set
			{
				_vm = value;
				OnPropertyChanged();
			}
		}

		CustomerViewModel customerViewModel;
		InvoiceViewModel invoiceViewModel;

		public MainViewModel()
		{
			ChangeViewCommand = new ChangeViewCommand(ChangeView);

			customerViewModel = new CustomerViewModel();
			invoiceViewModel = new InvoiceViewModel();

			VM = customerViewModel;
		}

		public ChangeViewCommand ChangeViewCommand { get; set; }

		private void ChangeView(string arg)
		{
			if (arg == "c")
			{
				VM = customerViewModel;
			}
			else
			{
				VM = invoiceViewModel;
			}
		}
	}
}
