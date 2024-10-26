using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Doctor : BaseAuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
    public string PersonalNumber { get; set; }
    public string LicenseNumber { get; set; }
    public decimal Salary { get; set; }
    public string Specialization { get; set; }
    public DateTime StartDate { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime ShiftStart { get; set; }
    public DateTime ShiftEnd { get; set; }
    public bool IsAvailable { get; set; }

}