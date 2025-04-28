namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence)
        {
            string lowerCase = sentence.ToLower();
          if(lowerCase.Contains("english")){
            return true;
          }else{
            return false;
          }
        }
    }
}
