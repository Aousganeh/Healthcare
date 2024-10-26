using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Equipment
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string? Manufacturer { get; set; }
    public string? SerialNumber { get; set; }
    public decimal Price { get; set; }
    public EquipmentStatus Status { get; set; }
    public DateTime PurchaseDate { get; set; }
    public int? RoomId { get; set; }
    public Room? Room { get; set; }
}