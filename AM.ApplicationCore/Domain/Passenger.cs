using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain;

public class Passenger
{
    public int Id { get; set; }
    [StringLength(7, MinimumLength = 7)]
    public string PassportNumber { get; set; } = string.Empty;
    [MinLength(3, ErrorMessage = "First name must have at least 3 characters.")]
    [MaxLength(25, ErrorMessage = "First name must have at most 25 characters.")]
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
    [RegularExpression(@"^\d{8}$", ErrorMessage = "TelNumber must contain exactly 8 digits.")]
    public string TelNumber { get; set; } = string.Empty;
    [EmailAddress]
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
