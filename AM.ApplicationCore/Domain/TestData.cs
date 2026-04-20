namespace AM.ApplicationCore.Domain;

public static class TestData
{
    // Planes
    public static Plane BoingPlane = new()
    {
        PlaneType = PlaneType.Boing,
        Capacity = 150,
        ManufactureDate = new DateTime(2015, 2, 3)
    };

    public static Plane Airbusplane = new()
    {
        PlaneType = PlaneType.Airbus,
        Capacity = 250,
        ManufactureDate = new DateTime(2020, 11, 11)
    };

    // Staffs
    public static Staff captain = new()
    {
        FirstName = "captain",
        LastName = "captain",
        EmailAddress = "captain.captain@gmail.com",
        BirthDate = new DateTime(1965, 1, 1),
        EmploymentDate = new DateTime(1999, 1, 1),
        Salary = 99999
    };

    public static Staff hostess1 = new()
    {
        FirstName = "hostess1",
        LastName = "hostess1",
        EmailAddress = "hostess1.hostess1@gmail.com",
        BirthDate = new DateTime(1995, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
    };

    public static Staff hostess2 = new()
    {
        FirstName = "hostess2",
        LastName = "hostess2",
        EmailAddress = "hostess2.hostess2@gmail.com",
        BirthDate = new DateTime(1996, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
    };

    // Travellers
    public static Traveller traveller1 = new()
    {
        FirstName = "traveller1",
        LastName = "traveller1",
        EmailAddress = "traveller1.traveller1@gmail.com",
        BirthDate = new DateTime(1980, 1, 1),
        HealthInformation = "no troubles",
        Nationality = "American"
    };

    public static Traveller traveller2 = new()
    {
        FirstName = "traveller2",
        LastName = "traveller2",
        EmailAddress = "traveller2.traveller2@gmail.com",
        BirthDate = new DateTime(1981, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "French"
    };

    public static Traveller traveller3 = new()
    {
        FirstName = "traveller3",
        LastName = "traveller3",
        EmailAddress = "traveller3.traveller3@gmail.com",
        BirthDate = new DateTime(1982, 1, 1),
        HealthInformation = "no troubles",
        Nationality = "Tunisian"
    };

    public static Traveller traveller4 = new()
    {
        FirstName = "traveller4",
        LastName = "traveller4",
        EmailAddress = "traveller4.traveller4@gmail.com",
        BirthDate = new DateTime(1983, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "American"
    };

    public static Traveller traveller5 = new()
    {
        FirstName = "traveller5",
        LastName = "traveller5",
        EmailAddress = "traveller5.traveller5@gmail.com",
        BirthDate = new DateTime(1984, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "Spanish"
    };

    // Flights
    public static Flight flight1 = new()
    {
        FlightId = 1,
        FlightDate = new DateTime(2022, 1, 1, 15, 10, 10),
        Destination = "Paris",
        EffectiveArrival = new DateTime(2022, 1, 1, 17, 10, 10),
        EstimatedDuration = 110,
        Passengers = new List<Passenger> { captain, hostess1, hostess2, traveller1, traveller2, traveller3, traveller4, traveller5 },
        MyPlane = Airbusplane
    };

    public static Flight flight2 = new()
    {
        FlightId = 2,
        FlightDate = new DateTime(2022, 2, 1, 21, 10, 10),
        Destination = "Paris",
        EffectiveArrival = new DateTime(2022, 2, 1, 23, 10, 10),
        EstimatedDuration = 105,
        MyPlane = BoingPlane
    };

    public static Flight flight3 = new()
    {
        FlightId = 3,
        FlightDate = new DateTime(2022, 3, 1, 5, 10, 10),
        Destination = "Paris",
        EffectiveArrival = new DateTime(2022, 3, 1, 6, 40, 10),
        EstimatedDuration = 100,
        MyPlane = BoingPlane
    };

    public static Flight flight4 = new()
    {
        FlightId = 4,
        FlightDate = new DateTime(2022, 4, 1, 6, 10, 10),
        Destination = "Madrid",
        EffectiveArrival = new DateTime(2022, 4, 1, 8, 10, 10),
        EstimatedDuration = 130,
        MyPlane = BoingPlane
    };

    public static Flight flight5 = new()
    {
        FlightId = 5,
        FlightDate = new DateTime(2022, 5, 1, 17, 10, 10),
        Destination = "Madrid",
        EffectiveArrival = new DateTime(2022, 5, 1, 18, 50, 10),
        EstimatedDuration = 105,
        MyPlane = BoingPlane
    };

    public static Flight flight6 = new()
    {
        FlightId = 6,
        FlightDate = new DateTime(2022, 6, 1, 20, 10, 10),
        Destination = "Lisbonne",
        EffectiveArrival = new DateTime(2022, 6, 1, 22, 30, 10),
        EstimatedDuration = 200,
        MyPlane = Airbusplane
    };

    // test list
    public static List<Flight> listFlights = new() { flight1, flight2, flight3, flight4, flight5, flight6 };

    // Compatibility aliases used by previous TP code
    public static Plane AirbusPlane => Airbusplane;
    public static Plane BoeingPlane => BoingPlane;
    public static Staff Captain => captain;
    public static Staff Hostess1 => hostess1;
    public static Staff Hostess2 => hostess2;
    public static Traveller Traveller1 => traveller1;
    public static Traveller Traveller2 => traveller2;
    public static Traveller Traveller3 => traveller3;
    public static Traveller Traveller4 => traveller4;
    public static Traveller Traveller5 => traveller5;
    public static List<Flight> ListFlights => listFlights;
}
