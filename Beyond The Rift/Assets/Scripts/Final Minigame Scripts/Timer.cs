using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart = 60;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        timeText.text = "Time Left: " + timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        timeText.text = "Time Left: " + Mathf.Round(timeStart).ToString();
    }
}
