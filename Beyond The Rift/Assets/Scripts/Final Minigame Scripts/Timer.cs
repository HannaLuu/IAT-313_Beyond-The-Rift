using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

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
            if (EnemyCounter.enemiesKilled > 18)
            {
                SceneManager.LoadScene("SuccessfulRescue");
            }
            else if (EnemyCounter.enemiesKilled < 18)
            {
                SceneManager.LoadScene("FailedRescue");
            }
        }
    }

    public void increaseTimer1()
    {
        timeStart += 10;
    }

    public void increaseTimer2()
    {
        timeStart += 5;
    }

    public void decreaseTimer()
    {
        timeStart -= 15;
    }
}
