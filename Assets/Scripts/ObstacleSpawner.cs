using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject spawnOption1;
    public GameObject spawnOption2;
    public GameObject spawnOption3;
    public GameObject spawnOption4;
    public GameObject spawnOption5;
    public GameObject spawnOption6;
    public GameObject redBall;
    public GameObject greenBall;
    public GameObject blueBall;
    public GameObject darkRedBall;
    public GameObject orangeBall;
    public GameObject purpleBall;
    public GameObject yellowBall;

    public GameObject shieldBall;
    public GameObject rollingBall;
    public GameObject unbreakableBall;

    public GameObject smallerPaddleUp;
    public GameObject fasterBallUp;
    public GameObject widerPaddleUp;

    private int randomNum;
    private bool spawnOption1Used = false;
    private bool spawnOption2Used = false;
    private bool spawnOption3Used = false;
    private bool spawnOption4Used = false;
    private bool spawnOption5Used = false;
    private bool spawnOption6Used = false;

    private GameObject obstacleToSpawn1;
    private GameObject obstacleToSpawn2;
    private GameObject obstacleToSpawn3;
    private GameObject obstacleToSpawn4;
    private GameObject obstacleToSpawn5;
    private GameObject obstacleToSpawn6;
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
        randomNum = Random.Range(0, 6);

        if (randomNum == 0)
        {
            obstacleToSpawn1 = Instantiate(shieldBall);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(widerPaddleUp);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(unbreakableBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(darkRedBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(smallerPaddleUp);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(redBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
        else if (randomNum == 1)
        {
            obstacleToSpawn1 = Instantiate(orangeBall);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(yellowBall);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(unbreakableBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(shieldBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(fasterBallUp);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(rollingBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
        else if (randomNum == 2)
        {
            obstacleToSpawn1 = Instantiate(redBall);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(redBall);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(purpleBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(unbreakableBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(widerPaddleUp);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(orangeBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
        else if (randomNum == 3)
        {
            obstacleToSpawn1 = Instantiate(widerPaddleUp);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(blueBall);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(unbreakableBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(rollingBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(darkRedBall);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(redBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
        else if (randomNum == 4)
        {
            obstacleToSpawn1 = Instantiate(shieldBall);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(yellowBall);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(unbreakableBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(darkRedBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(fasterBallUp);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(redBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
        else if (randomNum == 5)
        {
            obstacleToSpawn1 = Instantiate(widerPaddleUp);
            obstacleToSpawn1.transform.position = new Vector2(spawnOption1.transform.position.x, spawnOption1.transform.position.y);

            obstacleToSpawn2 = Instantiate(greenBall);
            obstacleToSpawn2.transform.position = new Vector2(spawnOption2.transform.position.x, spawnOption2.transform.position.y);

            obstacleToSpawn3 = Instantiate(shieldBall);
            obstacleToSpawn3.transform.position = new Vector2(spawnOption3.transform.position.x, spawnOption3.transform.position.y);

            obstacleToSpawn4 = Instantiate(darkRedBall);
            obstacleToSpawn4.transform.position = new Vector2(spawnOption4.transform.position.x, spawnOption4.transform.position.y);

            obstacleToSpawn5 = Instantiate(yellowBall);
            obstacleToSpawn5.transform.position = new Vector2(spawnOption5.transform.position.x, spawnOption5.transform.position.y);

            obstacleToSpawn6 = Instantiate(blueBall);
            obstacleToSpawn6.transform.position = new Vector2(spawnOption6.transform.position.x, spawnOption6.transform.position.y);
        }
    }
}
