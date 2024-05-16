namespace ObjectOrientedPrograming;

public class MedicalAppointment
{
  private string _patientName;
  private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public MedicalAppointment(string patientName)
    {
      _patientName = patientName;
      _date = DateTime.Now.AddDays(7);
    }

    public void Reschedule(DateTime date)
    {
      _date = date;
    }

    public void Reschedule(int month, int day)
    {
      _date = new DateTime(_date.Year, month, day);
    }


}
