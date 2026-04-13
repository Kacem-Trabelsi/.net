namespace AM.ApplicationCore.Domain;

public class Plane
{
    public int PlaneId { get; set; }
    public PlaneType PlaneType { get; set; }
    public int Capacity { get; set; }
    public DateTime ManufactureDate { get; set; }

    public ICollection<Flight> Flights { get; set; } = new List<Flight>();

    public override string ToString()
    {
        return $"Plane: id={PlaneId}, type={PlaneType}, capacity={Capacity}, manufacture={ManufactureDate:yyyy-MM-dd}, flights={Flights.Count}";
    }
}
