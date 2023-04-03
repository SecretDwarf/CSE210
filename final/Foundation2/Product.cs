public class Product{
// Product name
// product id
// Price
// quantity

    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string Name { get { return _name; } }
    public int Id { get { return _id; } }
    public double Price { get { return _price; } }
    public int Quantity { get { return _quantity; } }
}