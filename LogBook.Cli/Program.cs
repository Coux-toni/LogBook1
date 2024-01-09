using Logbook.Lib;

Console.WriteLine("Willkommen beim Fahrtenbuch");

IRepository repository = new xmlRepository("Logbook.xml");
List<Entry> entries = repository.GetAll();

