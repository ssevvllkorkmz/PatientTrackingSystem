using PatientTrackingApp;
using PatientTrackingApp.Models;

using var context = new AppDbContext();

// 1. Yeni bir hasta oluşturalım
var newPatient = new Patient 
{ 
    FirstName = "Şevval", 
    LastName = "Korkmaz", 
    TCNo = "12345678901" 
};

// 2. Veri tabanına ekleyelim
context.Patients.Add(newPatient);

// 3. Değişiklikleri kaydedelim (SQL'e INSERT komutu gider)
context.SaveChanges();

Console.WriteLine("Hasta başarıyla kaydedildi!");