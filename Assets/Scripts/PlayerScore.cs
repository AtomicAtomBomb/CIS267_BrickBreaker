using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class PlayerScore : MonoBehaviour
{
    private int playerScore;
    public TMP_Text guiScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScore = 0;
        PlayerPrefs.SetInt("FinalScore", 0);
        setGUIPlayerScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getScore()
    {
        return playerScore;
    }

    public void setPlayerScore(int val)
    {
        playerScore += val;
        PlayerPrefs.SetInt("FinalScore", playerScore);
        setGUIPlayerScore();
    }

    public void setGUIPlayerScore()
    {
        guiScore.text = "Score: ";
        guiScore.text += playerScore.ToString();
    }
}
