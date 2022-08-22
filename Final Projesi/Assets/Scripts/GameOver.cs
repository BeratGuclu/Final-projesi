using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text roundsText;

    void OnEnable()
    {
        roundsText.text = PlayerStats.Rounds.ToString();
    }

    public void Retry()
    {
        FindObjectOfType<SceneFader>().FadeTo(SceneManager.GetActiveScene().name);
    }

    public void Menu()
    {
        FindObjectOfType<SceneFader>().FadeTo("MainMenu");
    }
}
