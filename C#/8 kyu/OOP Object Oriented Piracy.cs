public class Ship
{
    public int Draft;
    public int Crew;

    public Ship(int draft, int crew)
    {
        Draft = draft;
        Crew = crew;//1.5
    }

    public bool IsWorthIt()
    {
        int cr = (int)(Crew * 1.5);
        int qwe = Draft - cr;

        return qwe > 20;
    }
}