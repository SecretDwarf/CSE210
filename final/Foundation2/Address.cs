public class Address {
// string street address
// String city,
// String state/province
// String country.
//   isUSA = boolclass Address
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string getCountry() {
        return _country;
    }
    public Address(string streetAddress, string city, string stateProvince, string country)
    {
      _streetAddress = streetAddress;
      _city = city;
      _stateProvince = stateProvince;
      _country = country;
   }

   public override string ToString()
   {
       return $"{_streetAddress}\n{_city}, {_stateProvince} {_country}";
   }
}