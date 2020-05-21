using UnityEngine;

public class EntityScr : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed * Time.deltaTime);
        if (transform.position.y <= -10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "Coin")
        {
            if (collision.gameObject.tag == "Player")
            {
                PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + 50);
                Destroy(gameObject);
            }
        }
        if (gameObject.tag == "Car")
        {
            if (collision.gameObject.tag == "Player")
            {
                FindObjectOfType<PlayerCsr>().hp = 0;
                Destroy(gameObject);
            }

        }
        if (gameObject.tag == "SHG")
        {
            if (collision.gameObject.tag == "Player")
            {
                FindObjectOfType<PlayerCsr>().hp--;
                Destroy(gameObject);
            }
        }
        if (gameObject.tag == "yama")
        {
            if (collision.gameObject.tag == "Player")
            {
                FindObjectOfType<PlayerCsr>().hp -= 2;
                Destroy(gameObject);
            }
        }

    }
}

