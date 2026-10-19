using UnityEngine;

public class BallScores : MonoBehaviour
{
    private PlayerScore playerScoreScript;
    private BallData ballData;
    private GameObject gameManager;
    public bool hitTwice = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        playerScoreScript = gameManager.GetComponent<PlayerScore>();
        ballData = GetComponent<BallData>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            playerScoreScript.setPlayerScore(ballData.getBallValue());
        }

        else if (collision.collider.CompareTag("FasterBall"))
        {
            playerScoreScript.setPlayerScore(ballData.getBallValue());
        }

        else if (collision.collider.CompareTag("Shield"))
        {
            playerScoreScript.setPlayerScore(ballData.getBallValue());
        }

        else if (collision.collider.CompareTag("SmallPaddleBall"))
        {
            playerScoreScript.setPlayerScore(ballData.getBallValue());
        }

        else if (collision.collider.CompareTag("WidePaddleBall"))
        {
            playerScoreScript.setPlayerScore(ballData.getBallValue());
        }
    }
}
