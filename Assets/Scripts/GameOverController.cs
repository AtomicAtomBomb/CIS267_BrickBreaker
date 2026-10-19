using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class GameOverController : MonoBehaviour
{
    public GameObject menu;
    private int levelPicker;
    public TMP_Text score;

    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        score.text = "Score: " + finalScore.ToString();
    }

    public void loadLevel1()
    {
        levelPicker = Random.Range(0, 2);
        if (levelPicker == 0)
        {
            DontDestroyOnLoad(this.gameObject);
            menu.SetActive(false);
            SceneManager.LoadScene("Level1");
            MainMenuManager.numBalls = 24;
        }

        if (levelPicker == 1)
        {
            DontDestroyOnLoad(this.gameObject);
            menu.SetActive(false);
            SceneManager.LoadScene("Level2");
            MainMenuManager.numBalls = 24;
        }
    }

    public void loadHome()
    {
        DontDestroyOnLoad(this.gameObject);
        menu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Exit Application...");
    }
}
