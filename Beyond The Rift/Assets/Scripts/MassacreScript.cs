using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
using UnityEngine.UI;

public class MassacreScript : MonoBehaviour
{
    public Flowchart myFlowchart;

    public float timeStart = 10;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        // timeText.text = "Time Left: " + timeStart.ToString();
        timeText.text = timeStart.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        // timeText.text = "Time Left: " + Mathf.Round(timeStart).ToString();
        timeText.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= 0)
        {

            myFlowchart.ExecuteBlock("Finish Minigame");


        }
    }
}

