// child of event
// string  speaker 
// max capacity
class Lecture : Event
{
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker Name: {SpeakerName}\nCapacity: {Capacity}";
    }
}
