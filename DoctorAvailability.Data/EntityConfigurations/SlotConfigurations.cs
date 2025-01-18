using DoctorAvailability.Data.Enitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorAvailability.Data.EntityConfigurations;

public class SlotConfigurations : IEntityTypeConfiguration<Slot>
{
    public void Configure(EntityTypeBuilder<Slot> builder)
    {
        builder.ToTable("Slots");

        builder.HasKey(s => s.Id);

        builder.Property(s => s.Id)
            .ValueGeneratedOnAdd();
        
        builder.Property(s => s.Time)
            .IsRequired();

        builder.Property(s => s.Cost)
            .IsRequired();

        builder.Property(s => s.IsReserved)
            .IsRequired();
    }
}