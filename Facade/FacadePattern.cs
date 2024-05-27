using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{

    /// <summary>
    /// Facade Interface
    /// </summary>
    public interface IOrderService
    {
        void ProccessOrder();
    }

    /// <summary>
    /// Facade Class
    /// </summary>
    public class OrderService(Product product,Payment payment,Invoice invoice) : IOrderService
    {
      
        public void ProccessOrder()
        {
            product.GetProductDetails();
            payment.MakePayment();
            invoice.Sendinvoice();
        }
    }

    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }

    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    public class Invoice
    {
        public void Sendinvoice()
        {
            Console.WriteLine("Invoice Send Successfully");
        }
    }
}
