using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Timer : MonoBehaviour
{
    public float timeStart = 10;
    public Text timeText;

    public Flowchart myFlowchart;

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

        if (timeStart <= 0)
        {
            myFlowchart.ExecuteBlock("Finish Training");
        }
    }
}
