using UnityEngine;

public class BallDestroyer : MonoBehaviour
{
    private int shieldHits = 0;
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
    }
}
