using TMPro;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    private int playerLives = 3;
    public TMP_Text guiLives;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setGUIPlayerLives();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getLives()
    {
        return playerLives;
    }

    public void loseLive(int damage = 1)
    {
        playerLives -= damage;
        setGUIPlayerLives();
    }

    public void setGUIPlayerLives()
    {
        guiLives.text = "Lives: ";
        guiLives.text += playerLives.ToString();
    }
}
