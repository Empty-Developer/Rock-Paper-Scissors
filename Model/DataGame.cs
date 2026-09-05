namespace Rock_Paper_Scissors.Model;

public enum GameObject
{
  Rock,
  Paper,
  Scissors
}

public class DataGame
{
  public int Player
  {
    get;
    private set;
  }
  public int Computer
  {
    get;
    private set;
  }

  public void AddPlayerCount()
  {
    Player++;
  }

  public void AddComputerCount()
  {
    Computer++;
  }
}
