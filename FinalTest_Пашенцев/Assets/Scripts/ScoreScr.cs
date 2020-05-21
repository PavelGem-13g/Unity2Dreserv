using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreScr : MonoBehaviour
{
    // Start is called before the first frame update
    TextMeshProUGUI text;
    public TimerScr timer;
    int resulrt;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        PlayerPrefs.SetInt("score", 0);

    }

    // Update is called once per frame
    void Update()
    {
        resulrt = PlayerPrefs.GetInt("score") + timer.time * 20;
        text.text = "Очки: " + resulrt;
    }
}
