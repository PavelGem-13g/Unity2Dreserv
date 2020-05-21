using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScr : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI text;
    public float timer=1f;
    public int time=0;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <=0)
        {
            time++;
            timer = 1f;
        }
        text.text = "" + time;
    }
}
