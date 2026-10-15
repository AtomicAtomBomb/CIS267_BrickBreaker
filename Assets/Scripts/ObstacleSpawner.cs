using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spawnOption1;
    public GameObject spawnOption2;
    public GameObject spawnOption3;
    public GameObject spawnOption4;

    public GameObject shieldBall;

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

        randomNum = Random.Range(0, 1);

        if (randomNum == 0)
        {
            //if the number is 0 spawn a red collectable
            obstacleToSpawn = Instantiate(shieldBall); //Instantiate means create the object / add it to the scene
            obstacleToSpawn.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);
        }
        else if (randomNum == 1)
        {
            obstacleToSpawn = Instantiate(shieldBall); //Instantiate means create the object / add it to the scene
            obstacleToSpawn.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);
        }
    }
}
