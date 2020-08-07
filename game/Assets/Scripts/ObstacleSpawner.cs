using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Obstacle;
    private float TimetoSpawn = 1f;
    private float TimebetweenOBSset = 4f;


    void Update()
    {

        if (Time.time >= TimetoSpawn)
        {
            Spawner();
            TimetoSpawn = Time.time + TimebetweenOBSset;
        }
    }

    void Spawner()
    {
        int randomIndex1 = Random.Range(0, 5);
        int randomIndex2 = Random.Range(5, 10);
        int randomIndex3 = Random.Range(10, 15);
        int randomIndex4 = Random.Range(15, 20);

        for (int i = 0; i < 5; i++)
        {
            if (randomIndex1 != i)
            {
                Instantiate(Obstacle, spawnPoints[i].position, Quaternion.identity);
            }

            if (randomIndex2 != (i + 5))
            {
                Instantiate(Obstacle, spawnPoints[i + 5].position, Quaternion.identity);
            }

            if (randomIndex3 != (i + 10))
            {
                Instantiate(Obstacle, spawnPoints[i + 10].position, Quaternion.identity);
            }

            if (randomIndex4 != (i + 15))
            {
                Instantiate(Obstacle, spawnPoints[i + 15].position, Quaternion.identity);
            }

        }
    }
}

