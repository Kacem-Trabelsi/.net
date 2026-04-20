using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;

namespace AM.ApplicationCore.Services;

public class FlightMethods : IFlightMethods
{
    public List<Flight> Flights { get; set; } = new();

    public List<DateTime> GetFlightDates(string destination)
    {
        var dates = new List<DateTime>();

        for (int i = 0; i < Flights.Count; i++)
        {
            if (Flights[i].Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                dates.Add(Flights[i].FlightDate);
            }
        }

        return dates;
    }

    public List<DateTime> GetFlightDatesForeach(string destination)
    {
        var dates = new List<DateTime>();

        foreach (var flight in Flights)
        {
            if (flight.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                dates.Add(flight.FlightDate);
            }
        }

        return dates;
    }

    public List<Flight> GetFlights(string filterType, string filterValue)
    {
        var property = typeof(Flight).GetProperty(filterType);
        if (property is null)
        {
            return new List<Flight>();
        }

        var result = new List<Flight>();

        foreach (var flight in Flights)
        {
            // TP asks for simple Flight attributes (e.g. Destination)
            var value = property.GetValue(flight)?.ToString();
            if (string.Equals(value, filterValue, StringComparison.OrdinalIgnoreCase))
            {
                result.Add(flight);
            }
        }

        return result;
    }

    // I. LINQ query syntax
    public List<string> ShowFlightDetails(Plane plane)
    {
        var query = from flight in Flights
                    where flight.Plane == plane
                    select $"Destination: {flight.Destination} - Date: {flight.FlightDate:dd/MM/yyyy} - Heure: {flight.FlightDate:HH:mm:ss}";
        return query.ToList();
    }

    public int ProgrammedFlightNumber(DateTime startDate)
    {
        var query = from flight in Flights
                    where flight.FlightDate >= startDate && flight.FlightDate <= startDate.AddDays(7)
                    select flight;
        return query.Count();
    }

    public double DurationAverage(string destination)
    {
        var query = from flight in Flights
                    where flight.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase)
                    select flight.EstimatedDuration;
        return query.Any() ? query.Average() : 0;
    }

    public List<Flight> OrderedDurationFlights()
    {
        var query = from flight in Flights
                    orderby flight.EstimatedDuration descending
                    select flight;
        return query.ToList();
    }

    public Flight? LongestFlight()
    {
        var ordered = OrderedDurationFlights();
        return ordered.FirstOrDefault();
    }

    public List<Traveller> SeniorTravellers(Flight flight)
    {
        var query = from passenger in flight.Passengers
                    where passenger is Traveller
                    orderby passenger.BirthDate
                    select (Traveller)passenger;
        return query.Take(3).ToList();
    }

    public Dictionary<string, List<DateTime>> DestinationGroupedFlights()
    {
        var query = from flight in Flights
                    group flight by flight.Destination into g
                    select new
                    {
                        Destination = g.Key,
                        Dates = (from f in g select f.FlightDate).ToList()
                    };

        return query.ToDictionary(x => x.Destination, x => x.Dates);
    }

    public Dictionary<string, int> FlightCountByDestination()
    {
        var query = from flight in Flights
                    group flight by flight.Destination into g
                    select new { Destination = g.Key, Count = g.Count() };

        return query.ToDictionary(x => x.Destination, x => x.Count);
    }

    public Flight? MostOccupiedFlight()
    {
        var query = from flight in Flights
                    orderby flight.Passengers.Count descending
                    select flight;
        return query.FirstOrDefault();
    }

    public List<string> GetDestinations()
    {
        var query = (from flight in Flights
                     select flight.Destination).Distinct();
        return query.ToList();
    }

    public bool ExistsParisFlight()
    {
        var query = from flight in Flights
                    where flight.Destination.Equals("Paris", StringComparison.OrdinalIgnoreCase)
                    select flight;
        return query.Any();
    }

    // II. LINQ predefined methods syntax
    public List<DateTime> GetFlightDatesMs(string destination) =>
        Flights
            .Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            .Select(f => f.FlightDate)
            .ToList();

    public List<string> ShowFlightDetailsMs(Plane plane) =>
        Flights
            .Where(f => f.Plane == plane)
            .Select(f => $"Destination: {f.Destination} - Date: {f.FlightDate:dd/MM/yyyy} - Heure: {f.FlightDate:HH:mm:ss}")
            .ToList();

    public int ProgrammedFlightNumberMs(DateTime startDate) =>
        Flights.Count(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7));

    public double DurationAverageMs(string destination) =>
        Flights.Any(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
            ? Flights
                .Where(f => f.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase))
                .Average(f => f.EstimatedDuration)
            : 0;

    public List<Flight> OrderedDurationFlightsMs() =>
        Flights.OrderByDescending(f => f.EstimatedDuration).ToList();

    public Flight? LongestFlightMs() =>
        Flights.OrderByDescending(f => f.EstimatedDuration).FirstOrDefault();

    public List<Traveller> SeniorTravellersMs(Flight flight) =>
        flight.Passengers
            .OfType<Traveller>()
            .OrderBy(t => t.BirthDate)
            .Take(3)
            .ToList();

    public Dictionary<string, List<DateTime>> DestinationGroupedFlightsMs() =>
        Flights
            .GroupBy(f => f.Destination)
            .ToDictionary(g => g.Key, g => g.Select(f => f.FlightDate).ToList());

    public Dictionary<string, int> FlightCountByDestinationMs() =>
        Flights
            .GroupBy(f => f.Destination)
            .ToDictionary(g => g.Key, g => g.Count());

    public Flight? MostOccupiedFlightMs() =>
        Flights
            .OrderByDescending(f => f.Passengers.Count)
            .FirstOrDefault();

    public List<string> GetDestinationsMs() =>
        Flights
            .Select(f => f.Destination)
            .Distinct()
            .ToList();

    public bool ExistsParisFlightMs() =>
        Flights.Any(f => f.Destination.Equals("Paris", StringComparison.OrdinalIgnoreCase));
}
