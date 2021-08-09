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
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Enemies Killed: " + enemiesKilled;

    }
}
