using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainLevel";

    public void Play()
    {
        SceneManager.LoadScene("MainLevel");
        Debug.Log("Play");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}