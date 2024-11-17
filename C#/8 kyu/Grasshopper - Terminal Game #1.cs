class Hero
{
    public string Name { get; private set; }
    public string Position { get; private set; } = "00";
    public float Health { get; private set; } = 100;
    public float Damage { get; private set; } = 5;
    public int Experience { get; private set; } = 0;
    public Hero(string name = "Hero")
    {
        Name = name;
    }
}