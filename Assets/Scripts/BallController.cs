using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D ball_rb;
    private int playerLives = 3;
    public GameObject ballStartPos;
    public GameObject normalPaddle;
    public GameObject widePaddle;
    public GameObject smallPaddle;
    private bool gameStarted = false;

    void Start()
    {
        widePaddle.SetActive(false);
        smallPaddle.SetActive(false);

        ball_rb = GetComponent<Rigidbody2D>();
        ball_rb.transform.position = new Vector2(ballStartPos.transform.position.x, ballStartPos.transform.position.y);
    }

    void Update()
    {
        if (gameStarted == false)
        {
            moveBallWithPaddle();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ball_rb.linearVelocity = Vector2.down * initialSpeed;
                gameStarted = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("paddle_left"))
        {
            if (ball_rb != null)
            {
                Vector2 diagonalLeftDirection = new Vector2(-1f, 1f).normalized;
                ball_rb.linearVelocity = diagonalLeftDirection * initialSpeed;
            }
        }

        if (collision.collider.CompareTag("paddlemiddle_left"))
        {
            if (ball_rb != null)
            {
                Vector2 diagonalLeftDirection = new Vector2(-0.5f, 1f).normalized;
                ball_rb.linearVelocity = diagonalLeftDirection * initialSpeed;
            }
        }

        if (collision.collider.CompareTag("middle"))
        {
            if (ball_rb != null)
            {
                Vector2 diagonalLeftDirection = new Vector2(0f, 1f).normalized;
                ball_rb.linearVelocity = diagonalLeftDirection * initialSpeed;
            }
        }

        if (collision.collider.CompareTag("paddlemiddle_right"))
        {
            if (ball_rb != null)
            {
                Vector2 diagonalLeftDirection = new Vector2(0.5f, 1f).normalized;
                ball_rb.linearVelocity = diagonalLeftDirection * initialSpeed;
            }
        }

        if (collision.collider.CompareTag("paddle_right"))
        {
            if (ball_rb != null)
            {
                Vector2 diagonalLeftDirection = new Vector2(1f, 1f).normalized;
                ball_rb.linearVelocity = diagonalLeftDirection * initialSpeed;
            }
        }

        if (collision.gameObject.CompareTag("FasterBall"))
        {
            initialSpeed = 15f;
        }

        if (collision.gameObject.CompareTag("WidePaddleBall"))
        {
            widePaddle.transform.position = normalPaddle.transform.position;
            widePaddle.transform.rotation = normalPaddle.transform.rotation;

            normalPaddle.SetActive(false);
            widePaddle.SetActive(true);
        }

        if (collision.gameObject.CompareTag("SmallPaddleBall"))
        {
            smallPaddle.transform.position = normalPaddle.transform.position;
            smallPaddle.transform.rotation = normalPaddle.transform.rotation;

            normalPaddle.SetActive(false);
            smallPaddle.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OOB"))
        {
            playerLives--;
            ball_rb.transform.position = new Vector2(ballStartPos.transform.position.x, ballStartPos.transform.position.y);
            if (playerLives == 0)
            {
                Debug.Log("Restart Level");
                SceneManager.LoadScene("Level1");
            }
        }
    }

    private void moveBallWithPaddle()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        ball_rb.linearVelocity = new Vector2(inputHorizontal * initialSpeed, ball_rb.linearVelocityY);
    }
}
