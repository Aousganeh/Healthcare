using Healthcare.Domain.Entities.Common;

namespace Healthcare.Domain.Entities;

public class Doctor : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Specialization { get; set; }
    public string Clinic { get; set; }
    public string LicenseNumber { get; set; }
    public string ImageUrl { get; set; } 
    public DateTime DateOfBirth { get; set; }
    public bool IsActive { get; set; }
    public DateTime ShiftStart { get; set; }
    public DateTime ShiftEnd { get; set; } 
    
    public List<Patient> Patients { get; set; }
    public List<Appointment> Appointments { get; set; }
 
}