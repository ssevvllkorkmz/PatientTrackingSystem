using Microsoft.EntityFrameworkCore;
using PatientTrackingApp.Models; // Modeller klasörünü görmesi için şart

namespace PatientTrackingApp; // Eğer Data klasörüne koyduysan sonuna .Data ekle

public class AppDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PatientDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}