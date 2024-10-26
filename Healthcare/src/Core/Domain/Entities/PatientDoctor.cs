using Healthcare.Domain.Entities.Common;

namespace Healthcare.Domain.Entities;

public class PatientDoctor : BaseEntity
{
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}