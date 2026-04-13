namespace AM.ApplicationCore.Domain;

public class Traveller : Passenger
{
    public string HealthInformation { get; set; } = string.Empty;
    public string Nationality { get; set; } = string.Empty;

    protected override string PassengerTypeText() => base.PassengerTypeText() + " I am a traveller";

    public override string ToString()
    {
        return $"Traveller: {base.ToString()}, nationality={Nationality}, health={HealthInformation}";
    }
}
