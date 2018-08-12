using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimeLeft : MonoBehaviour {

    public int time;

    Text text;

    public float timer;

    void Awake()
    {
        timer = time;
        text = GetComponent<Text>();
    }

    void Update ()
    {
        timer -= Time.deltaTime;
        text.text = "Time: " + timer.ToString("f");
    }
}
