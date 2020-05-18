using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    public float localSpeed;
    public float dmgTimer = 0.2f;
    public bool isDamage = false;
    public Player player;
    public int hp;
<<<<<<< HEAD
<<<<<<< HEAD
    public int mode=1;
    public bool isRight;
    public float modeTimer;
    public float localModeTimer;
    public GameObject zds;
    public float bossDetectFinder;

=======
    // Start is called before the first frame update
>>>>>>> parent of dffd52a... unity hse holidays
=======
    // Start is called before the first frame update
>>>>>>> parent of dffd52a... unity hse holidays
    void Start()
    {
        player = FindObjectOfType<Player>();
        localSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD

        if (bossDetectFinder>0)
        {
            bossDetectFinder -= Time.deltaTime;
            if(bossDetectFinder<=0)
            {
                ZCalculate();
                bossDetectFinder = 2f;
            }
        }
        else 
        {
            ZCalculate();
        }
        if (mode == 1)
        {
            transform.position += transform.up * speed * Time.deltaTime;
        }
        if (mode==2) 
        {
            modeTimer -= Time.deltaTime;
            if (modeTimer <= 0) 
            {
                modeTimer = localModeTimer;
                mode = 1;
                speed = localSpeed;
            }
            speed = 3 * localSpeed;
            if(isRight) transform.position += transform.right * speed * Time.deltaTime;
            else transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (isDamage && mode==1)
=======
        ZCalculate();
        transform.position += transform.up * speed * Time.deltaTime;
        if (isDamage)
>>>>>>> parent of dffd52a... unity hse holidays
=======
        ZCalculate();
        transform.position += transform.up * speed * Time.deltaTime;
        if (isDamage)
>>>>>>> parent of dffd52a... unity hse holidays
        {
            dmgTimer -= Time.deltaTime;
            if (dmgTimer <= 0)
            {
                isDamage = false;
                dmgTimer = 2f;
            }
        }
        else speed = localSpeed;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void ZCalculate()
    {
        Vector2 playerPos = Camera.main.WorldToScreenPoint(player.transform.position);
        Vector2 zombiePos = Camera.main.WorldToScreenPoint(transform.position);
        Vector2 resultVector = playerPos - zombiePos;
        float angle = Vector2.SignedAngle(Vector2.up, resultVector);
        transform.eulerAngles = new Vector3(0, 0, angle);
    }
    public void TakeDamage()
    {
        speed = 0;
        isDamage = true;
        hp--;
    }

}
