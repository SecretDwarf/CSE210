public class DVD : Loanable
{

    private string _serialNumber;
    private string _title;
    private int _cost;
    
    public DVD(string title, string serialNumber, int cost)
    {
        _serialNumber = serialNumber;
        _title = title;
        _cost = cost; 
    }

    public void ShowDVDDetails()
    {
        Console.WriteLine($"{_title}: {_serialNumber}, {_cost}");
    }
}