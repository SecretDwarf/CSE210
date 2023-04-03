using System;
// Menu
// Standard details:
// Display title, description, date, time, and address.
// Full details:
// Display all of the above, plus the type of event and information specific to that event type.
//  For lectures, this includes the speaker's name and capacity. For receptions, this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
// Short description:
// display the type of event, title, and date.

class Program
{
    static void Main(string[] args)
    {
        Address LectureAddress = new Address("Address Line 1", "Address Line 2", "City", "State", "Zip Code");
        Address ReceptionAddress = new Address("Address Line 1", "Address Line 2", "City", "State", "Zip Code");
        Address OutdoorGatheringAddress = new Address("Address Line 1", "Address Line 2", "City", "State", "Zip Code");


        // Create an event of each type
        Lecture lecture = new Lecture("Lecture Title", "Lecture Description", "Lecture Date", "Lecture Time", LectureAddress, "Speaker Name", 100);
        Reception reception = new Reception("Reception Title", "Reception Description", "Reception Date", "Reception Time", ReceptionAddress, "RSVP Email");
        Outdoor Outdoor = new Outdoor("Outdoor Gathering Title", "Outdoor Gathering Description", "Outdoor Gathering Date", "Outdoor Gathering Time", OutdoorGatheringAddress);

        // Call each method to generate marketing messages
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());

        Console.WriteLine(Outdoor.GetStandardDetails());
        Console.WriteLine(Outdoor.GetFullDetails());
        Console.WriteLine(Outdoor.GetShortDescription());
    }
}