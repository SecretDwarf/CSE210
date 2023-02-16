public class Loanable
{
    private bool _IsCheckedIn = true;

    public void CheckOut()
    {
        _IsCheckedIn = false;
    }

    public void Checkin()
    {
        _IsCheckedIn = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Available: {_IsCheckedIn}");
    }
}