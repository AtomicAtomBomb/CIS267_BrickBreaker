using UnityEngine;

public class BallData : MonoBehaviour
{
    [SerializeField]
    private int ballValue;

    public int getBallValue()
    {
        return ballValue;
    }
}
