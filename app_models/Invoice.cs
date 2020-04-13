using app_models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace BillingManagement.Models
{
    public class Invoice : INotifyPropertyChanged
    {
        static int nextId;
        public int InvoiceId { get; private set; }
        public DateTime CreationDateTime { get; private set; }

        private Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set
            {
                _customer = value;
                OnPropertyChanged();
            }
        }

        private double _subTotal;
        public double SubTotal {
            get { return _subTotal; } 
            set
            {
                _subTotal = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FedTax));
                OnPropertyChanged(nameof(ProvTax));
                OnPropertyChanged(nameof(Total));
            }
        }

        public double FedTax => SubTotal * 0.05;
        public double ProvTax => SubTotal * 0.09975;
        public double Total => SubTotal + FedTax + ProvTax;

        public Invoice()
        {
            InvoiceId = Interlocked.Increment(ref nextId);
            CreationDateTime = DateTime.Now;
        }

        public Invoice(Customer arg)
        {
            InvoiceId = Interlocked.Increment(ref nextId);
            Customer = arg;
            CreationDateTime = DateTime.Now;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
