// See https://aka.ms/new-console-template for more information
using ClassExample;


Crew crew1 = new Crew()
{
    Id = 1,
    Name = "Henry Morgan",
    Role = Role.Captain,
    DoB = new DateTime(1635, 1, 2),
    Schedule = new Schedule
    {
        Start = new DateTime(2021, 10, 31),
        End = new DateTime(2021, 11, 30)
    }
};

Passenger passenger1 = new Passenger()
{
    Id = 1000,
    Name = "Tom Hanks",
    Cabin = 106,
    Origin = "Liverpool",
    Destination = "New York",
    DoB = new DateTime(1956, 7, 9),
    Ticket = Ticket.FirstClass
};

List<Person> persons = new List<Person>();
persons.Add((Person)passenger1);
persons.Add(crew1);

foreach (var person in persons)
{
    if (person.GetType() == typeof(Passenger))
    {
        Passenger p = (Passenger)person;
        Console.WriteLine(
            $"Type: {p.GetType().Name}\t " +
            $"Name: {p.Name}\t " +
            $"Ticket: {p.Ticket}");
    }
    else if (person.GetType() == typeof(Crew))
    {
        Crew c = (Crew)person;
        Console.WriteLine(
            $"Type: {c.GetType().Name}\t " +
            $"Name: {c.Name}\t " +
            $"Role: {c.Role}");
    }
}
Console.WriteLine("Tom Hanks new ticket: ");
foreach (var ticket in Enum.GetValues(typeof(Ticket)))
{
    Console.WriteLine((int)ticket + " " + ticket.ToString());
}
Console.Write("Please enter number of new ticket: ");
string input = Console.ReadLine();

int i = int.Parse(input);

passenger1.ChangeTicket((Ticket)i);

Console.WriteLine("New ticket for Tom: " + passenger1.Ticket);


//Implicit & Explicit conversion
//Implicit = automatically
//Explicit = manual
//double d = 10.5;
//byte b = 100;
//int i = b;

//int i2 = 520;
//byte b2 = (byte)i2;
//string s = "32!";
//try
//{
//    int i = int.Parse(s);
//}
//catch (Exception e)
//{

//    Console.WriteLine("Kan ikke forstå det du indtastede. Det skal være et tal. Prøv igen");
//}

//int j;
//bool canWeParseIt = int.TryParse(s, out j);
//if (!canWeParseIt) Console.WriteLine("Kan ikke forstå d...");

//Console.WriteLine("Whaaat?!?: " + i2%256 + "Byter: " +b2 ); //520 / 256 = % 520-(2x256) = 8 
//Console.ReadKey();

