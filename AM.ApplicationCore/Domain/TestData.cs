namespace AM.ApplicationCore.Domain;

public static class TestData
{
    public static Plane AirbusPlane = new()
    {
        PlaneId = 1,
        PlaneType = PlaneType.Airbus,
        Capacity = 250,
        ManufactureDate = new DateTime(2020, 11, 11)
    };

    public static Plane BoeingPlane = new()
    {
        PlaneId = 2,
        PlaneType = PlaneType.Boeing,
        Capacity = 150,
        ManufactureDate = new DateTime(2015, 2, 3)
    };

    public static Staff Captain = new()
    {
        FirstName = "captain",
        LastName = "captain",
        EmailAddress = "Captain.captain@gmail.com",
        BirthDate = new DateTime(1965, 1, 1),
        EmploymentDate = new DateTime(1999, 1, 1),
        Salary = 99999
    };

    public static Staff Hostess1 = new()
    {
        FirstName = "hostess1",
        LastName = "hostess1",
        EmailAddress = "hostess1.hostess1@gmail.com",
        BirthDate = new DateTime(1995, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
    };

    public static Staff Hostess2 = new()
    {
        FirstName = "hostess2",
        LastName = "hostess2",
        EmailAddress = "hostess2.hostess2@gmail.com",
        BirthDate = new DateTime(1996, 1, 1),
        EmploymentDate = new DateTime(2020, 1, 1),
        Salary = 999
    };

    public static Traveller Traveller1 = new()
    {
        FirstName = "Traveller1",
        LastName = "Traveller1",
        EmailAddress = "Traveller1.Traveller1@gmail.com",
        BirthDate = new DateTime(1980, 1, 1),
        HealthInformation = "No troubles",
        Nationality = "American"
    };

    public static Traveller Traveller2 = new()
    {
        FirstName = "Traveller2",
        LastName = "Traveller2",
        EmailAddress = "Traveller2.Traveller2@gmail.com",
        BirthDate = new DateTime(1981, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "French"
    };

    public static Traveller Traveller3 = new()
    {
        FirstName = "Traveller3",
        LastName = "Traveller3",
        EmailAddress = "Traveller3.Traveller3@gmail.com",
        BirthDate = new DateTime(1982, 1, 1),
        HealthInformation = "No troubles",
        Nationality = "Tunisian"
    };

    public static Traveller Traveller4 = new()
    {
        FirstName = "Traveller4",
        LastName = "Traveller4",
        EmailAddress = "Traveller4.Traveller4@gmail.com",
        BirthDate = new DateTime(1983, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "American"
    };

    public static Traveller Traveller5 = new()
    {
        FirstName = "Traveller5",
        LastName = "Traveller5",
        EmailAddress = "Traveller5.Traveller5@gmail.com",
        BirthDate = new DateTime(1984, 1, 1),
        HealthInformation = "Some troubles",
        Nationality = "Spanish"
    };

    public static List<Flight> ListFlights = new()
    {
        new Flight
        {
            FlightId = 1,
            FlightDate = new DateTime(2022, 1, 1, 15, 10, 10),
            Destination = "Paris",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 1, 1, 17, 10, 10),
            EstimatedDuration = 110,
            Plane = AirbusPlane,
            Passengers = new List<Passenger> { Traveller1, Traveller2, Traveller3, Traveller4, Traveller5 }
        },
        new Flight
        {
            FlightId = 2,
            FlightDate = new DateTime(2022, 2, 1, 21, 10, 10),
            Destination = "Paris",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 2, 2, 23, 10, 10),
            EstimatedDuration = 105,
            Plane = BoeingPlane
        },
        new Flight
        {
            FlightId = 3,
            FlightDate = new DateTime(2022, 3, 1, 5, 10, 10),
            Destination = "Paris",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 3, 1, 6, 40, 10),
            EstimatedDuration = 100,
            Plane = BoeingPlane
        },
        new Flight
        {
            FlightId = 4,
            FlightDate = new DateTime(2022, 4, 1, 6, 10, 10),
            Destination = "Madrid",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 4, 1, 8, 10, 10),
            EstimatedDuration = 130,
            Plane = BoeingPlane
        },
        new Flight
        {
            FlightId = 5,
            FlightDate = new DateTime(2022, 5, 1, 17, 10, 10),
            Destination = "Madrid",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 5, 1, 18, 50, 10),
            EstimatedDuration = 105,
            Plane = BoeingPlane
        },
        new Flight
        {
            FlightId = 6,
            FlightDate = new DateTime(2022, 6, 1, 20, 10, 10),
            Destination = "Lisbonne",
            Departure = "Tunis",
            EffectiveArrival = new DateTime(2022, 6, 1, 22, 30, 10),
            EstimatedDuration = 200,
            Plane = AirbusPlane
        }
    };
}
