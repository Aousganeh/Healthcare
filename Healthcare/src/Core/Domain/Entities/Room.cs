using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Room : BaseAuditableEntity
{
    public int Floor { get; set; }
    public string Number { get; set; }
    public RoomType Type { get; set; }
    public int Capacity { get; set; }
    private int CurrentOccupancy { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsActive { get; set; }

    public IEnumerable<Patient> Patients { get; set; }
    public IEnumerable<Equipment> Equipments { get; set; }

}