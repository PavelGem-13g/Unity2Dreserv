using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScr : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject one;
    public GameObject two;
    public GameObject tree;
    public GameObject four;
    public PlayerCsr player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.hp == 0)
        {
            one.SetActive(false);
            two.SetActive(false);
            tree.SetActive(false);
            four.SetActive(false);
        }
        if (player.hp == 1)
        {
            one.SetActive(true);
            two.SetActive(false);
            tree.SetActive(false);
            four.SetActive(false);
        }
        if (player.hp == 2)
        {
            one.SetActive(true);
            two.SetActive(true);
            tree.SetActive(false);
            four.SetActive(false);
        }
        if (player.hp == 3)
        {
            one.SetActive(true);
            two.SetActive(true);
            tree.SetActive(true);
            four.SetActive(false);
        }
        if (player.hp == 4)
        {
            one.SetActive(true);
            two.SetActive(true);
            tree.SetActive(true);
            four.SetActive(true);
        }
    }
}
