public class ForeignDVD : DVD
{

    private string _language;
    private string _title;
    private int _cost;
    
    public ForeigDVD(string title, string language, int cost)
    {
        _language = language;
        _title = title;
        _cost = cost; 
    }

    public void ShowForeigDVDDetails()
    {
        Console.WriteLine($"{_title}: {_language}, {_cost}");
    }
}