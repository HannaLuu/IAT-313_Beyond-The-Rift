using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class EnemyCounter : MonoBehaviour
{
    public static int enemiesKilled = 0;

    Text score;

    public Flowchart myFlowchart;

    private void Start()
    {
        enemiesKilled = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Enemies Killed: " + enemiesKilled;

    }
}
