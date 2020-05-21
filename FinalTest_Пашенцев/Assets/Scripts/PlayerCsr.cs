using UnityEngine;

public class PlayerCsr : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public int hp;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hp > 0)
        {

            if (Input.GetKey(KeyCode.D))
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            }
            if (transform.position.y < -4f)
            {
                transform.position = new Vector3(transform.position.x, -4f, 0);
            }
            if (transform.position.y > 4f)
            {
                transform.position = new Vector3(transform.position.x, 4f, 0);
            }
            if (transform.position.x < -8f)
            {
                transform.position = new Vector3(-8f, transform.position.y, 0);
            }
            if (transform.position.x > 8f)
            {
                transform.position = new Vector3(8f, transform.position.y, 0);
            }
        }
        else Destroy(gameObject);
        
    }
}
