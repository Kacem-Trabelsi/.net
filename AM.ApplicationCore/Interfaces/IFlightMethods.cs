using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces;

public interface IFlightMethods
{
    List<Flight> Flights { get; set; }
    List<DateTime> GetFlightDates(string destination);
    List<DateTime> GetFlightDatesForeach(string destination);
    List<Flight> GetFlights(string filterType, string filterValue);
    List<DateTime> ShowFlightDetails(Plane plane);
    int ProgrammedFlightNumber(DateTime startDate);
    double DurationAverage(string destination);
    List<Flight> OrderedDurationFlights();
    Flight? LongestFlight();
    List<Traveller> SeniorTravellers(Flight flight);
    Dictionary<string, List<DateTime>> DestinationGroupedFlights();
    Dictionary<string, int> FlightCountByDestination();
    Flight? MostOccupiedFlight();
    List<string> GetDestinations();
    bool ExistsParisFlight();

    // Same operations using LINQ method syntax
    List<DateTime> GetFlightDatesMs(string destination);
    List<DateTime> ShowFlightDetailsMs(Plane plane);
    int ProgrammedFlightNumberMs(DateTime startDate);
    double DurationAverageMs(string destination);
    List<Flight> OrderedDurationFlightsMs();
    Flight? LongestFlightMs();
    List<Traveller> SeniorTravellersMs(Flight flight);
    Dictionary<string, List<DateTime>> DestinationGroupedFlightsMs();
    Dictionary<string, int> FlightCountByDestinationMs();
    Flight? MostOccupiedFlightMs();
    List<string> GetDestinationsMs();
    bool ExistsParisFlightMs();
}
