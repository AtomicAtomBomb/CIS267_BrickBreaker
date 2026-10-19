using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject menu;
    private int levelPicker;
    public static int numBalls = 24;

    public void loadLevel1()
    {
        levelPicker = Random.Range(0, 2);
        if (levelPicker == 0)
        {
            DontDestroyOnLoad(this.gameObject);
            menu.SetActive(false);
            SceneManager.LoadScene("Level1");
            numBalls = 24;
        }

        if (levelPicker == 1)
        {
            DontDestroyOnLoad(this.gameObject);
            menu.SetActive(false);
            SceneManager.LoadScene("Level2");
            numBalls = 24;
        }
    }

    public void loadHelp()
    {
        DontDestroyOnLoad(this.gameObject);
        menu.SetActive(false);
        SceneManager.LoadScene("Help");
    }

    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Exit Application...");
    }
}
