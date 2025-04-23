public class Player
{
  private int health = 100;
  public int Health
  {
    get
    {
      return this.health;
    }
    set
    {
      health = value;
    }
  }
  
  public Player()
  {
    
  }
  
  public bool CheckAlive()
  {
    if(this.Health <= 0)
    {
      return false;
    }
    else if(this.Health > 0)
    {
      return true;
    }else{
      return false;
    }
  }
}
