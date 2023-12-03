using System;
using Foundation2;

class Program
{
    static void Main(string[] args)
    {
        Product bananas = new(){
            Name = "Bunch of Bananas",
            ProductId = 1,
            Price = 0.55,
            Quantity = 6
        };

        Product basketball = new(){
            Name = "Basketball",
            ProductId = 2,
            Price = 21.99,
            Quantity = 1
        };

        Product balloons = new(){
            Name = "Balloons",
            ProductId = 3,
            Price = 4.99,
            Quantity = 5
        };

        Customer Batte = new(){
            Name = "Batte",
            Address = new(){
                Street = "Blue Boulevard",
                City = "Brussels",
                State = "Bahia",
                Country = "Brazil"
            }
        };

        Customer Carl = new(){
            Name = "Carl",
            Address = new(){
                Street = "Condor Calade",
                City = "Chicago",
                State = "Illinois",
                Country = "USA"
            }
        };

        Order order1 = new(){
            Products = new List<Product> {bananas, basketball},
            Customer = Carl
        };

        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        double orderPrice1 = order1.CalculatePrice();
        order1.DisplayOrder(packingLabel1, shippingLabel1, orderPrice1);

        Order order2 = new(){
            Products = new List<Product> {bananas, balloons},
            Customer = Batte
        };

        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();
        double orderPrice2 = order2.CalculatePrice();
        order2.DisplayOrder(packingLabel2, shippingLabel2, orderPrice2);
    }
}