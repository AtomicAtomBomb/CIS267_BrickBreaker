//====================================================
//Author: Marcel Dahmoun
//Date: 10-07-2026
//Desc: Handles movement of the paddle using the A and D keys
//Attach: Paddle
//====================================================

using UnityEngine;
using UnityEngine.SceneManagement;

public class PaddleController : MonoBehaviour
{
    private Rigidbody2D paddle_rb;

    [SerializeField]
    private float movementSpeed;

    void Start()
    {
        paddle_rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movePaddleHorizontal();
    }

    void movePaddleHorizontal()
    {
        float inputHorizontal = Input.GetAxisRaw("Horizontal");
        paddle_rb.linearVelocity = new Vector2(inputHorizontal * movementSpeed, paddle_rb.linearVelocityY);
    }
}
