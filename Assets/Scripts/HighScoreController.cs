using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScoreController : MonoBehaviour
{
    public GameObject Menu;

    public void loadHome()
    {
        DontDestroyOnLoad(this.gameObject);
        Menu.SetActive(false);
        SceneManager.LoadScene("MainMenu");
    }
}
