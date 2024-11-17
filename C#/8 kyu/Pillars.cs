public static class Kata
{
    public static int Pillars(int numPill, int dist, int width)
    {

        int distanceInCm = dist * 100;


        int totalDistance = (numPill - 1) * distanceInCm + (numPill - 2) * width;
        if (totalDistance < 0)
        {
            return 0;
        }
        return totalDistance;
    }
}