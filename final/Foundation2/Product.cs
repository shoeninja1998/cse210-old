namespace Foundation2
{
    public class Product { 
        private string _name;
        private int _productId;
        private double _price;
        private int _quantity;

        // Getters & Setters
        public string Name
        {
            get{return _name;}
            set{_name = value;} 
        }
        public int ProductId
        {
            get{return _productId;}
            set{_productId = value;}
        }
        public double Price
        {
            get{return _price;}
            set{_price = value;}
        }
        public int Quantity
        {
            get{return _quantity;}
            set{_quantity = value;}
        }
    }
}