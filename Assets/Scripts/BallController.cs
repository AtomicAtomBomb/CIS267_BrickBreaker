using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D ball_rb;

    [SerializeField]
    private float ballSpeed;
    void Start()
    {
        ball_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
}
