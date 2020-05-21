using UnityEngine;

public class SpawnerScr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject coin;
    public GameObject yama;
    public GameObject car;
    public GameObject shlagbaum;
    public float spawnTimer;
    public float localSpawnTimer;
    System.Random random = new System.Random();
    public int vibor;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = localSpawnTimer;
            vibor = random.Next(0, 4);
            GameObject entity;
            if (vibor == 0)
            {
                entity = Instantiate(coin);
            }
            else if (vibor == 1)
            {
                entity = Instantiate(yama);
            }
            else if (vibor == 2)
            {
                entity = Instantiate(car);
            }
            else if (vibor == 3)
            {
                entity = Instantiate(shlagbaum);
            }
            else entity = Instantiate(coin);
            entity.transform.position = transform.position;
        }
    }
}
