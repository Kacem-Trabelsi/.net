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
}
