using UnityEngine;
using UnityEngine.SceneManagement;

public class BallDestroyer : MonoBehaviour
{
    public int shieldHits = 0;
    public GameObject teleportingOption1;
    public GameObject teleportingOption2;
    public GameObject teleportingOption3;
    public GameObject teleportingBall;
    public GameObject menu;
    private int teleportingOption;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PoolBall"))
        {
            Destroy(collision.gameObject);
            DecrementBallCount();
        }

        if (collision.gameObject.CompareTag("Shield"))
        {
            shieldHits++;
            if (shieldHits == 2)
            {
                Destroy(collision.gameObject);
                DecrementBallCount();
            }
        }

        if (collision.gameObject.CompareTag("TeleportingBall"))
        {
            teleportingOption = Random.Range(0, 3);
            if (teleportingOption == 0)
            {
                gameObject.transform.position = new Vector2(teleportingOption1.transform.position.x, teleportingOption1.transform.position.y);
            }

            if (teleportingOption == 1)
            {
                gameObject.transform.position = new Vector2(teleportingOption2.transform.position.x, teleportingOption2.transform.position.y);
            }

            if (teleportingOption == 2)
            {
                gameObject.transform.position = new Vector2(teleportingOption3.transform.position.x, teleportingOption3.transform.position.y);
            }
        }

        if (collision.gameObject.CompareTag("FasterBall"))
        {
            Destroy(collision.gameObject);
            DecrementBallCount();
        }

        if (collision.gameObject.CompareTag("WidePaddleBall"))
        {
            Destroy(collision.gameObject);
            DecrementBallCount();
        }

        if (collision.gameObject.CompareTag("SmallPaddleBall"))
        {
            Destroy(collision.gameObject);
            DecrementBallCount();
        }
    }

    private void DecrementBallCount()
    {
        MainMenuManager.numBalls--;

        if (MainMenuManager.numBalls <= 0)
        {
            menu.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }
    }
}
