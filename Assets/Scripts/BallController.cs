using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float initialSpeed = 5f;
    private Rigidbody2D ball_rb;

    void Start()
    {
        ball_rb = GetComponent<Rigidbody2D>();
        ball_rb.linearVelocity = Vector2.down * initialSpeed;
    }

    void Update()
    {
        
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
    }
}
