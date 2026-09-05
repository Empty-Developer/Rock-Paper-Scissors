using Avalonia.Controls;
using Avalonia.Interactivity;
using Rock_Paper_Scissors.Model;
using Rock_Paper_Scissors.Presenters;

namespace Rock_Paper_Scissors.View;

public partial class MainWindow : Window
{
  private readonly GamePresenters _presenter;
  public MainWindow()
  {
      InitializeComponent();
      DataGame game = new DataGame();
      _presenter = new GamePresenters(game);
  }
  private void RockButton_Click(
      object? sender,
      RoutedEventArgs e)
  {
      Play(GameObject.Rock);
  }
  private void PaperButton_Click(
      object? sender,
      RoutedEventArgs e)
  {
      Play(GameObject.Paper);
  }
  private void ScissorsButton_Click(
      object? sender,
      RoutedEventArgs e)
  {
      Play(GameObject.Scissors);
  }
  private void Play(GameObject playerObject)
  {
      string result = _presenter.Play(playerObject);
      ResultLabel.Content = result;
      PlayerScoreLabel.Content = _presenter.PlayerScore;
      ComputerScoreLabel.Content = _presenter.ComputerScore;
  }
}