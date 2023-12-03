using Foundation2;
public class Order{
    private List<Product> _products;
    public Customer _customer;

// Methods
    public string GetPackingLabel(){
        string packingLabel = null;

        foreach(Product product in _products){
            packingLabel += $"{product.Name}, ID: {product.ProductId}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel(){
        string addressString = $"{_customer.Address.Street}, {_customer.Address.City}, {_customer.Address.State}, {_customer.Address.Country}";
        return $"{_customer.Name}\n{addressString}";
    }
    public double CalculatePrice(){
        double order_price = 0;
    // Calculates the total cost of all products ordered
        foreach(Product product in _products){
            order_price += product.Price * product.Quantity;
        }
    // Adds $5 in shipping fees if customer lives in USA
        if(_customer.Address.CheckAddressUSA()==true){
            order_price += 5;
        }
    // Adds $35 if customer doesn't live in USA
        else{
            order_price += 35;
        }
        return order_price;
    }

    public void DisplayOrder(string packingLabel, string shippingLabel, double orderPrice){
        Console.WriteLine($"{shippingLabel}\nItems Purchased:\n{packingLabel}Total: ${orderPrice}\n");
    }


// Getters & Setters
    public List<Product> Products{
        get{return _products;}
        set{_products = value;}
    }
    public Customer Customer{
        get{return _customer;}
        set{_customer = value;}
    }
}