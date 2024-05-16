namespace ObjectOrientedPrograming;

class MedicalAppointmentPrinter
{
  public void Print(MedicalAppointment medicalAppointment) 
  {
    Console.WriteLine($"Appoint will take place on {medicalAppointment.Date}");
  }
}

public class MedicalAppointment
{
  private string _patientName;
  public DateTime Date {get; private set;}

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        Date = date;
    }

    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
      _patientName = patientName;
      Date = DateTime.Now.AddDays(daysFromNow);
    }

    public void Reschedule(DateTime date)
    {
      Date = date;
      var printer = new MedicalAppointmentPrinter();
      // This keyword refers to the current instance of the class
      printer.Print(this);
    }

    public void Reschedule(int month, int day)
    {
      Date = new DateTime(Date.Year, month, day);
    }


}
