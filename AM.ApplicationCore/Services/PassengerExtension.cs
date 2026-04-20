using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Services;

public static class PassengerExtension
{
    public static string UpperFullName(this Passenger passenger)
    {
        if (string.IsNullOrWhiteSpace(passenger.FirstName) || string.IsNullOrWhiteSpace(passenger.LastName))
        {
            return $"{passenger.FirstName} {passenger.LastName}".Trim();
        }

        string firstName = char.ToUpper(passenger.FirstName[0]) + passenger.FirstName[1..].ToLower();
        string lastName = char.ToUpper(passenger.LastName[0]) + passenger.LastName[1..].ToLower();
        return $"{firstName} {lastName}";
    }
}
