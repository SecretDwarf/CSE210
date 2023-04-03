class Order
{
    // Customer Name = String
    // Display _products
    // Display packing label
    // Display shipping label

    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0.0;

        foreach (Product product in _products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        if (_customer.IsUSA())
            totalPrice += 5.0;
        else
            totalPrice += 35.0;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in _products)
        {
            packingLabel += $"{product.Name} ({product.Id})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.showName()}\n{_customer.showAddress()}";
    }
}