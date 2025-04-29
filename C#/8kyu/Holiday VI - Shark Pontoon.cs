public class Kata
{
    public static string Shark(
      int pontoonDistance, 
      int sharkDistance, 
      int youSpeed, 
      int sharkSpeed, 
      bool dolphin)
    {
       double effectiveSharkSpeed = dolphin ? sharkSpeed / 2.0 : sharkSpeed;
    double yourTime = (double)pontoonDistance / youSpeed;
    double sharkTime = (double)sharkDistance / effectiveSharkSpeed;

    return yourTime < sharkTime ? "Alive!" : "Shark Bait!";
    }
}
