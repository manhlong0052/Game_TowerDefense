using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text roundsText;

    void OnEnable()
    {
        gameObject.SetActive(true);
        roundsText.text = PlayerStats.Rounds.ToString();
    }
    
    public void Retry()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
