public class Cat : Animal
{
  public Cat(string name) : base(name)
  {
   
  }
  public override string Speak(){
  return this.Name + " meows."; 
  }
  
}
