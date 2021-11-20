using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItem
    {
        private string productName;
        private int quantity;
        private decimal unitPrice;

        public OrderItem(string productName, int quantity, decimal unitPrice)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
        }

        public string ProductName
        {
            get
            {
                return productName;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
        }


        public virtual decimal GetValue()
        {
            return quantity * unitPrice;
        }
        public override string ToString()
        {
            return $"{productName}, Cena: {unitPrice} PLN, {quantity} szt, wartość : {GetValue()} PLN";
        }
    }
}
