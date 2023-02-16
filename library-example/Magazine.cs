public class Magazine : Loanable
{

    private string _edition;
    private string _title;
    private int _upc;
    
    public Magazine(string title, string edition, int upc)
    {
        _edition = edition;
        _title = title;
        _upc = upc; 
    }

    public void ShowMagazineDetails()
    {
        Console.WriteLine($"{_title}: {_edition}, {_upc}");
    }
}