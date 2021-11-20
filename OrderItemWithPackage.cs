using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class OrderItemWithPackage : OrderItem
    {
        private string packageName;

        public OrderItemWithPackage(string productName, int quantity, decimal unitPrice, string packageName, decimal packagePrice) : base(productName, quantity, unitPrice)
        {
            this.packageName = packageName;
            this.PackagePrice = packagePrice;
        }

        protected decimal PackagePrice { get; }


        public override decimal GetValue()
        {
            return base.GetValue() * (Quantity * PackagePrice);
        }

        public override string ToString()
        {
            return $"{ProductName}, cena: {UnitPrice} PLN, opakowanie: {packageName}, cena opakowania: {PackagePrice} PLN, {Quantity} szt, wartość: {} PLN"
        }
    }
}
