using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject lowestYSpawn;
    public GameObject highestYSpawn;
    public GameObject lowestXSpawn;
    public GameObject highestXSpawn;

    public GameObject redPoolBall;
    public GameObject greenPoolBall;
    public GameObject bluePoolBall;
    public GameObject darkRedPoolBall;
    public GameObject orangePoolBall;
    public GameObject purplePoolBall;
    public GameObject yellowPoolBall;

    private int randomNum;

    private GameObject obstacleToSpawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCollectable();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void spawnCollectable()
    {
        //get a random number to determine which object to spawn

        randomNum = Random.Range(0, 7);

        if (randomNum == 0)
        {
            //if the number is 0 spawn a red collectable
            obstacleToSpawn = Instantiate(redPoolBall); //Instantiate means create the object / add it to the scene
        }
        else if (randomNum == 1)
        {
            //if the number is 1 spawn a grey collectable
            obstacleToSpawn = Instantiate(greenPoolBall);
        }
        else if (randomNum == 2)
        {
            //if the number is 2 spawn a green collectable
            obstacleToSpawn = Instantiate(bluePoolBall);
        }
        else if (randomNum == 3)
        {
            //if the number is 2 spawn a green collectable
            obstacleToSpawn = Instantiate(darkRedPoolBall);
        }
        else if (randomNum == 4)
        {
            //if the number is 2 spawn a green collectable
            obstacleToSpawn = Instantiate(orangePoolBall);
        }
        else if (randomNum == 5)
        {
            //if the number is 2 spawn a green collectable
            obstacleToSpawn = Instantiate(purplePoolBall);
        }
        else if (randomNum == 6)
        {
            //if the number is 2 spawn a green collectable
            obstacleToSpawn = Instantiate(yellowPoolBall);
        }

        //tell the collectable where to spawn
        obstacleToSpawn.transform.position = new Vector2(Random.Range(lowestXSpawn.transform.position.x, highestXSpawn.transform.position.x), Random.Range(lowestYSpawn.transform.position.y, highestYSpawn.transform.position.y));
    }
}
