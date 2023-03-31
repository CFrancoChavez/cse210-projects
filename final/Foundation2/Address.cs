public class Address
{
    private string street;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string street, string city, string stateProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public string Street
    {
        get { return street; }
    }

    public string City
    {
        get { return city; }
    }

    public string StateProvince
    {
        get { return stateProvince; }
    }

    public string Country
    {
        get { return country; }
    }

    public bool IsInUSA()
    {
        return country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateProvince} {country}";
    }
}
