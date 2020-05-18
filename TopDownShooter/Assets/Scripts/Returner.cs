using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returner : MonoBehaviour
{
    public int zombieNumOnLevel;
    public GameObject button;
    public GameObject win;
    public GameObject die;
    public Player player;
    public GameObject reloadButton;
    private void Start()
    {
        PlayerPrefs.SetInt("zombieCountOnLevel",0);
        button.SetActive(false);
        win.SetActive(false);
        die.SetActive(false);
        reloadButton.SetActive(false);
    }
    void Update()
    {
        player = FindObjectOfType<Player>();
        if (zombieNumOnLevel == PlayerPrefs.GetInt("zombieCountOnLevel")||player==null) 
        {
            button.SetActive(true);
            if (zombieNumOnLevel == PlayerPrefs.GetInt("zombieCountOnLevel"))
            {
                win.SetActive(true);
            }
            else 
            {
                die.SetActive(true);
                reloadButton.SetActive(true);
            }
        }
    }
}
