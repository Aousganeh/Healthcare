using Healthcare.Domain.Enums;
using Healthcare.Domain.ValueObjects;

namespace Healthcare.Domain.Entities;

public class Patient
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
    public string PersonalNumber { get; set; }
    public Address RegistrationAddress { get; set; }
    public Address CurrentAddress { get; set; }
    public BloodGroup BloodGroup { get; set; }


}