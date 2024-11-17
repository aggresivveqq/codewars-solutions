using System;

public class Guesser
{
    private int number;
    private int lives;

    public Guesser(int number, int lives)
    {
        this.number = number;
        this.lives = lives;
    }

    public bool Guess(int n)
    {
        if (lives <= 0)
        {
            throw new InvalidOperationException("You have no lives left to guess!");
        }


        if (n == number)
        {
            return true;
        }
        else
        {
            lives--;
            return false;
        }
    }
}