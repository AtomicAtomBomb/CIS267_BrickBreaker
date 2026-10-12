using UnityEngine;

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
}
