using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
<<<<<<< HEAD
<<<<<<< HEAD
    public int mode;
    public Player player;
   
=======
>>>>>>> parent of dffd52a... unity hse holidays
=======
>>>>>>> parent of dffd52a... unity hse holidays
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * Time.deltaTime*speed;
        if (transform.position.x < -15f || transform.position.x > 15f || transform.position.y < -15f || transform.position.y > 15f)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Zombie"&& mode==1)
        {
            GameObject z = collision.gameObject;
            z.GetComponent<Zombie>().TakeDamage();
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Player" && mode == 2)
        {
            player.hp--;
            Destroy(gameObject);
        }
    }
}
