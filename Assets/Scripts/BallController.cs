//====================================================
//Author: Marcel Dahmoun
//Date: 10-07-2026
//Desc: Handles movement of ball and where ball bounces off paddle
//Attach: Ball
//====================================================
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D ball_rb;
    public PlayerLives lives;
    public GameObject ballStartPos;
    public GameObject smallBallStartPos;
    public GameObject wideBallStartPos;
    public GameObject normalPaddle;
    public GameObject widePaddle;
    public GameObject smallPaddle;
    public GameObject menu;
    private bool gameStarted = false;
    private bool smallPaddleActive = false;
    private bool widePaddleActive = false;

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
            widePaddleActive = true;

            if (smallPaddleActive == true)
            {
                smallPaddle.SetActive(false);
                smallPaddleActive = false;
            }
        }

        if (collision.gameObject.CompareTag("SmallPaddleBall"))
        {
            smallPaddle.transform.position = normalPaddle.transform.position;
            smallPaddle.transform.rotation = normalPaddle.transform.rotation;

            normalPaddle.SetActive(false);
            smallPaddle.SetActive(true);
            smallPaddleActive = true;

            if (widePaddleActive == true)
            {
                widePaddle.SetActive(false);
                widePaddleActive = false;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("OOB"))
        {
            lives.loseLive();
            ball_rb.transform.position = new Vector2(ballStartPos.transform.position.x, ballStartPos.transform.position.y);
            ball_rb.linearVelocity = new Vector2(0, 0);
            gameStarted = false;
            initialSpeed = 10f;
            if (lives.getLives() == 0)
            {
                menu.SetActive(false);
                SceneManager.LoadScene("GameOver");
            }

            if (widePaddleActive == true)
            {
                ball_rb.transform.position = new Vector2(wideBallStartPos.transform.position.x, wideBallStartPos.transform.position.y);
                ball_rb.linearVelocity = new Vector2(0, 0);
            }

            if (smallPaddleActive == true)
            {
                ball_rb.transform.position = new Vector2(smallBallStartPos.transform.position.x, smallBallStartPos.transform.position.y);
                ball_rb.linearVelocity = new Vector2(0, 0);
            }
        }
    }
        
    private void moveBallWithPaddle()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        ball_rb.linearVelocity = new Vector2(inputHorizontal * initialSpeed, ball_rb.linearVelocityY);
    }
}
