using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainLevel";

    public void Play()
    {
        FindObjectOfType<SceneFader>().FadeTo(levelToLoad);
    }

    public void Quit()
    {
        Debug.Log("Exciting");
        Application.Quit();
    }
}
