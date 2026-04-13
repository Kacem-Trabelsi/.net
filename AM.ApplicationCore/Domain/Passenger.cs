namespace AM.ApplicationCore.Domain;

public class Passenger
{
    public string PassportNumber { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string TelNumber { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;

    public ICollection<Flight> Flights { get; set; } = new List<Flight>();

    protected virtual string PassengerTypeText() => "I am a passenger";

    public virtual void PassengerType()
    {
        Console.WriteLine(PassengerTypeText());
    }

    public bool CheckProfile(string nom, string prenom)
    {
        return LastName == nom && FirstName == prenom;
    }

    public bool CheckProfile(string nom, string prenom, string? email = null)
    {
        return email is null
            ? LastName == nom && FirstName == prenom
            : LastName == nom && FirstName == prenom && EmailAddress == email;
    }

    public override string ToString()
    {
        return $"Passenger: {FirstName} {LastName}, passport={PassportNumber}, birth={BirthDate:yyyy-MM-dd}, email={EmailAddress}";
    }
}
