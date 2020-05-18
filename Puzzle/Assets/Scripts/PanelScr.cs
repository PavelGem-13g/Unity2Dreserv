using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cell;
    public int x, y;
    public int sum;
    void Start()
    {
        sum = x * y;
        for (int i = 1; i < sum+ 1; i++) 
        {
            GameObject c = Instantiate(cell, gameObject.transform);
            c.name = "" + i;
            c.transform.SetParent(this.gameObject.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
