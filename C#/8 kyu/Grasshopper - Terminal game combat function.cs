using System;

public static class Game
{
    public static float Combat(float health, float damage)
    {
        float IfDeath = health - damage;
        if (IfDeath < 0)
        {
            return 0;
        }
        else
        {
            return IfDeath;
        }
    }
}