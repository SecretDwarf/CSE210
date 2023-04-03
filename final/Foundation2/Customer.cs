public class Customer{
// Name = string
// Get Address()
// Get isUSA
    private string _name;
    Address _address;
    
    public bool IsUSA()
   {
        if (_address.getCountry() == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
   }

    public string showAddress() {
        return _address.ToString();
    }

    public string showName() {
        return _name;
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    } 
}