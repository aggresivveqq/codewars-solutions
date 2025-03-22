public class Solution
{
    public static int[] rowWeights (final int[] weights)
    {   int firstTeam = 0;
        int secondTeam = 0;
       int counter = 0;
      for(int i = 0;i<weights.length;i++){
        if(i % 2 == 0){
          secondTeam += weights[i];
        }else{
          firstTeam += weights[i];
        }
      }
     return new int[]{secondTeam,firstTeam};
    }
}
