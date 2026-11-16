using Giovanni.Domain.Common;
using Giovanni.Domain.Enums;

namespace Giovanni.Domain.Entities;

public class Reservation : BaseEntity
{
    public string GuestName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? Phone { get; set; }

    public DateOnly Date { get; set; }

    public TimeOnly Time { get; set; }

    public int Guests { get; set; }

    public ReservationStatus Status { get; set; }
        = ReservationStatus.Pending;
}