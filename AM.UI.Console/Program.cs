using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

// ===== TP1 =====
Console.WriteLine("=== TP1 ===");
Console.WriteLine();

// II. Instanciation (ex. 7)
var plane1 = new Plane();
plane1.PlaneId = 1;
plane1.PlaneType = PlaneType.Boeing;
plane1.Capacity = 180;
plane1.ManufactureDate = new DateTime(2019, 5, 12);
Console.WriteLine("Ex.7 — avion (constructeur implicite + proprietes):");
Console.WriteLine(plane1);
Console.WriteLine();

// II. Instanciation (ex. 9)
var plane3 = new Plane
{
    PlaneId = 3,
    PlaneType = PlaneType.Airbus,
    Capacity = 220,
    ManufactureDate = new DateTime(2021, 1, 15)
};
Console.WriteLine("Ex.9 — avion (initialiseur d'objet):");
Console.WriteLine(plane3);
Console.WriteLine();

// III.10 — Polymorphisme par signature
var p = new Passenger
{
    FirstName = "Jean",
    LastName = "Dupont",
    EmailAddress = "jean.dupont@mail.test"
};
Console.WriteLine("Ex.10 — CheckProfile:");
Console.WriteLine($"  (a) nom + prenom: {p.CheckProfile("Dupont", "Jean")}");
Console.WriteLine($"  (b) + email explicite: {p.CheckProfile("Dupont", "Jean", "jean.dupont@mail.test")}");
string? noEmail = null;
Console.WriteLine($"  (c) parametre email optionnel (null): {p.CheckProfile("Dupont", "Jean", noEmail)}");
Console.WriteLine();

// III.11 — Polymorphisme par heritage
Console.WriteLine("Ex.11 — PassengerType:");
var passenger = new Passenger();
var staff = new Staff();
var traveller = new Traveller();
passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();
Console.WriteLine();

// ===== TP2 =====
var flightMethods = new FlightMethods
{
    Flights = TestData.ListFlights
};

Console.WriteLine("=== TP2 - II. Structures iteratives ===");
Console.WriteLine();

Console.WriteLine("1) GetFlightDates(\"Paris\") avec FOR");
var datesFor = flightMethods.GetFlightDates("Paris");
foreach (var date in datesFor)
{
    Console.WriteLine($"- {date:dd/MM/yyyy HH:mm:ss}");
}
Console.WriteLine();

Console.WriteLine("2) GetFlightDatesForeach(\"Paris\") avec FOREACH");
var datesForeach = flightMethods.GetFlightDatesForeach("Paris");
foreach (var date in datesForeach)
{
    Console.WriteLine($"- {date:dd/MM/yyyy HH:mm:ss}");
}
Console.WriteLine();

Console.WriteLine("3) GetFlights(\"Destination\", \"Paris\")");
var flightsToParis = flightMethods.GetFlights("Destination", "Paris");
foreach (var flight in flightsToParis)
{
    Console.WriteLine(
        $"- Id={flight.FlightId}, Date={flight.FlightDate:dd/MM/yyyy HH:mm:ss}, " +
        $"Destination={flight.Destination}, Duration={flight.EstimatedDuration}, " +
        $"EffectiveArrival={flight.EffectiveArrival:dd/MM/yyyy HH:mm:ss}, Plane={flight.Plane?.PlaneType}");
}

Console.WriteLine();
Console.WriteLine("=== TP3 - LINQ (Query Syntax) ===");

Console.WriteLine("ShowFlightDetails(Airbus):");
foreach (var d in flightMethods.ShowFlightDetails(TestData.AirbusPlane))
{
    Console.WriteLine($"- {d:dd/MM/yyyy HH:mm:ss}");
}

Console.WriteLine($"ProgrammedFlightNumber(01/01/2022): {flightMethods.ProgrammedFlightNumber(new DateTime(2022, 1, 1))}");
Console.WriteLine($"DurationAverage(\"Paris\"): {flightMethods.DurationAverage("Paris")}");
Console.WriteLine($"LongestFlight Id: {flightMethods.LongestFlight()?.FlightId}");

Console.WriteLine("OrderedDurationFlights:");
foreach (var f in flightMethods.OrderedDurationFlights())
{
    Console.WriteLine($"- Id={f.FlightId}, Duration={f.EstimatedDuration}");
}

Console.WriteLine("SeniorTravellers (flight 1):");
foreach (var t in flightMethods.SeniorTravellers(TestData.ListFlights[0]))
{
    Console.WriteLine($"- {t.UpperFullName()} ({t.BirthDate:dd/MM/yyyy})");
}

Console.WriteLine("DestinationGroupedFlights:");
foreach (var group in flightMethods.DestinationGroupedFlights())
{
    Console.WriteLine($"Destination {group.Key}");
    foreach (var d in group.Value)
    {
        Console.WriteLine($"  Decollage: {d:dd/MM/yyyy HH:mm:ss}");
    }
}

Console.WriteLine("FlightCountByDestination:");
foreach (var item in flightMethods.FlightCountByDestination())
{
    Console.WriteLine($"- {item.Key}: {item.Value}");
}

Console.WriteLine($"MostOccupiedFlight Id: {flightMethods.MostOccupiedFlight()?.FlightId}");
Console.WriteLine($"GetDestinations: {string.Join(", ", flightMethods.GetDestinations())}");
Console.WriteLine($"ExistsParisFlight: {flightMethods.ExistsParisFlight()}");

Console.WriteLine();
Console.WriteLine("=== TP3 - LINQ (Method Syntax) ===");
Console.WriteLine($"GetFlightDatesMs(\"Paris\"): {flightMethods.GetFlightDatesMs("Paris").Count} dates");
Console.WriteLine($"ShowFlightDetailsMs(Airbus): {flightMethods.ShowFlightDetailsMs(TestData.AirbusPlane).Count} dates");
Console.WriteLine($"ProgrammedFlightNumberMs(01/01/2022): {flightMethods.ProgrammedFlightNumberMs(new DateTime(2022, 1, 1))}");
Console.WriteLine($"DurationAverageMs(\"Paris\"): {flightMethods.DurationAverageMs("Paris")}");
Console.WriteLine($"LongestFlightMs Id: {flightMethods.LongestFlightMs()?.FlightId}");
Console.WriteLine($"OrderedDurationFlightsMs first Id: {flightMethods.OrderedDurationFlightsMs().FirstOrDefault()?.FlightId}");
Console.WriteLine($"SeniorTravellersMs count: {flightMethods.SeniorTravellersMs(TestData.ListFlights[0]).Count}");
Console.WriteLine($"DestinationGroupedFlightsMs groups: {flightMethods.DestinationGroupedFlightsMs().Count}");
Console.WriteLine($"FlightCountByDestinationMs groups: {flightMethods.FlightCountByDestinationMs().Count}");
Console.WriteLine($"MostOccupiedFlightMs Id: {flightMethods.MostOccupiedFlightMs()?.FlightId}");
Console.WriteLine($"GetDestinationsMs: {string.Join(", ", flightMethods.GetDestinationsMs())}");
Console.WriteLine($"ExistsParisFlightMs: {flightMethods.ExistsParisFlightMs()}");
