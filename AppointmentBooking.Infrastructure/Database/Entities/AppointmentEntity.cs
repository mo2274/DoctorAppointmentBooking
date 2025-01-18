using AppointmentBooking.Domain.Models;

namespace AppointmentBooking.Infrastructure.Database.Entities;

public class AppointmentEntity
{
    public Guid Id { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; }
    public AppointmentStatus Status { get; set; }
    public DateTime ReservedAt { get; set; }
    
    public static AppointmentEntity FromDomainModel(Appointment appointment)
    {
        return new AppointmentEntity
        {
            Id = appointment.Id,
            PatientId = appointment.PatientId,
            PatientName = appointment.PatientName.Get(),
            Status = appointment.Status,
            ReservedAt = appointment.ReservedAt
        };
    }
    
    public Appointment ToDomainModel()
    {
        return new Appointment(Id, PatientId, PatientName, ReservedAt, Status);
    }
    
}