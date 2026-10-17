using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    private int shieldHits = 0;
    private BallController initialSpeed;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PoolBall"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Shield"))
        {
            shieldHits++;
            if (shieldHits == 2)
            {
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.CompareTag("FasterBall"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("LaserBall"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("WidePaddleBall"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("SmallPaddleBall"))
        {
            Destroy(collision.gameObject);
        }
    }
}
