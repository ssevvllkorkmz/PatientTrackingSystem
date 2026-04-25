namespace PatientTrackingApp.Models;

public class Appointment {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Note { get; set; }
    public int PatientId { get; set; }
}