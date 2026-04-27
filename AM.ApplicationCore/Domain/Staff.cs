using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain;

public class Staff : Passenger
{
    public DateTime EmploymentDate { get; set; }
    public string Function { get; set; } = string.Empty;
    [Column(TypeName = "money")]
    public double Salary { get; set; }

    protected override string PassengerTypeText() => base.PassengerTypeText() + " I am a Staff Member";

    public override string ToString()
    {
        return $"Staff: {base.ToString()}, function={Function}, salary={Salary}, since={EmploymentDate:yyyy-MM-dd}";
    }
}
