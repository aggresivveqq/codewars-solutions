using System;

public static class Kata
{
  public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
  {
      if (enteredCode != correctCode)
            return false;

        DateTime currentDateTime;
        DateTime expirationDateTime;

        if (!DateTime.TryParse(currentDate, out currentDateTime) ||
            !DateTime.TryParse(expirationDate, out expirationDateTime))
            return false;
        return currentDateTime <= expirationDateTime;
  }
}
