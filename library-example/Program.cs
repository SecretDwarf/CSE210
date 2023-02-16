// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Book book = new Book ("Maze Runner", "97811111111", 2345623);

book.Display();
book.CheckOut();
book.Display();
book.Checkin();
book.Display();
book.ShowBookDetails();

DVD DVD = new DVD ("Magazine", "97811111111", 2345623);

DVD.Display();
DVD.CheckOut();
DVD.Display();
DVD.Checkin();
DVD.Display();
DVD.ShowDVDDetails();

Magazine Magazine = new Magazine ("Magazine", "2", 2345623);

Magazine.Display();
Magazine.CheckOut();
Magazine.Display();
Magazine.Checkin();
Magazine.Display();
Magazine.ShowMagazineDetails();