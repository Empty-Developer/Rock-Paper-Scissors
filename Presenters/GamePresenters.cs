using System;
using Rock_Paper_Scissors.Model;

namespace Rock_Paper_Scissors.Presenters;

public class GamePresenters
{
  // get data model
  private readonly DataGame _game;

  // set data model in value
  public GamePresenters(DataGame game)
  {
    _game = game;
  }

  // get random computer choice
  private readonly Random _random = new();
  private GameObject GetComputerObject()
  {
    return (GameObject)_random.Next(0, 3);
  }

  private string GetResult(GameObject playerObject, GameObject computerObject)
  {
    if (playerObject == computerObject)
    {
      return "Draw";
    }

    if (
      playerObject == GameObject.Rock && computerObject == GameObject.Scissors ||
      playerObject == GameObject.Paper && computerObject == GameObject.Rock ||
      playerObject == GameObject.Scissors && computerObject == GameObject.Paper
    )
    {
      _game.AddPlayerCount();
      return "You Win!";
    }

    _game.AddComputerCount();
    return "You Lose!";
  }

  // output result
  public string Play(GameObject playerObject)
  {
    GameObject computerObject = GetComputerObject();

    string result = GetResult(playerObject, computerObject);

    return $"Computer: {GetMoveName(computerObject)} — " +
           $"You: {GetMoveName(playerObject)} — {result}";
  }

  // convert data to names
  private string GetMoveName(GameObject move)
  {
    return move switch
    {
        GameObject.Rock => "Rock",
        GameObject.Paper => "Paper",
        GameObject.Scissors => "Scissors",
        _ => ""
    };
  }
}