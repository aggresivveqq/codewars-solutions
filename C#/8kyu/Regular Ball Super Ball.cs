using System;

public class Ball {
  public string ballType { get; set; }
  
    public Ball(string ballType = "regular")
    {
        this.ballType = ballType; 
    }

    public void DisplayBallType()
    {
        Console.WriteLine("Ball Type: " + ballType);
    }
}
