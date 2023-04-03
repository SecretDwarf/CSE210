// child of event
// String weather forecast.
class Outdoor : Event
{
    public string WeatherForecastStatement { get; set; }

    public Outdoor(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {

    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather Forecast Statement: {WeatherForecastStatement}";
    }
}