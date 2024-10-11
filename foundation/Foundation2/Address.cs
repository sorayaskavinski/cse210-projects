using System;
public class Address
{
    private string _address;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    public Address(string address, string city, string stateOrProvince,string country)
    {
        string _address = address;
        string _city = city;
        string _stateOrProvince = stateOrProvince;
        string _country = country;
    }
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    public string GetFullAddress()
    {
        return $"{_address}\n {_city}, {_stateOrProvince}\n {_country}";
    }
}