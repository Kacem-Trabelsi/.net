namespace AM.ApplicationCore.Domain;

public class Flight
{
    public int FlightId { get; set; }
    public DateTime FlightDate { get; set; }
    public string Departure { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public DateTime EffectiveArrival { get; set; }
    public double EstimatedDuration { get; set; }

    public Plane? Plane { get; set; }
    public Plane? MyPlane
    {
        get => Plane;
        set => Plane = value;
    }

    public ICollection<Passenger> Passengers { get; set; } = new List<Passenger>();

    public override string ToString()
    {
        return $"Flight: id={FlightId}, {Departure}->{Destination}, date={FlightDate:yyyy-MM-dd}, duration={EstimatedDuration}, arrival={EffectiveArrival:O}";
    }
}
