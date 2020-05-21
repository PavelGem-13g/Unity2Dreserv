using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadScr : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed*Time.deltaTime, 0);
        if (transform.position.y <= -70)
        {
            transform.position = new Vector3(0, 70, 0);
        }
    }

}
