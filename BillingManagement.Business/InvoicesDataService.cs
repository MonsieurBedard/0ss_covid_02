using app_models;
using BillingManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingManagement.Business
{
    class InvoicesDataService : IDataService<Invoice>
    {
        readonly List<Invoice> invoices;

        List<Customer> customers = new CustomersDataService().GetAll().ToList();

        public InvoicesDataService()
        {
            initValues();
        }

        private void initValues()
        {
            Random rnd = new Random();

            foreach (var customer in customers)
            {
                int nbInvoices = rnd.Next(10);

                for (int i = 0; i < nbInvoices; i++)
                {
                    var invoice = new Invoice(customer);
                    invoice.SubTotal = rnd.NextDouble() * 100 + 50;
                    customer.Invoices.Add(invoice);
                    invoices.Add(invoice);
                }
            }
        }

        public IEnumerable<Invoice> GetAll()
        {
            foreach (Invoice invoice in invoices)
            {
                yield return invoice;
            }
        }
    }
}
