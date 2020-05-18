using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cell;
    public GameObject fragment;
    public Sprite[] spriteList;
    //System.Random random = new System.Random();
    public int x, y;
    public int num=0;
    public int amount =0;
    void Start()
    {
        for (int i = 0; i < y; i++) 
        {
            for (int j = 0; j < x; j++) 
            {
                num++;
                GameObject c = Instantiate(cell, transform);
                c.name = "" + num;
                c.GetComponent<RectTransform>().anchoredPosition = new Vector3(-800+(205*j),400-205*i);
            }
        }
        num = 0;
        for (int n = 0; n < x * y; n++) 
        {
            num++;
            GameObject f = Instantiate(fragment, transform);
            f.name = "" + num;
            f.GetComponent<RectTransform>().anchoredPosition = new Vector3(Random.Range(100, 800), Random.Range(-400, 400));
            f.GetComponent<Image>().sprite = spriteList[n];
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (amount >= x*y) 
        {
            Debug.Log("You won!");
        }
    }
}
