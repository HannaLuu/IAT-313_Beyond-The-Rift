using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DummyCounter : MonoBehaviour
{
    public static int dummiesKilled = 0;

    Text score;

    private void Start()
    {
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Dummies Killed: " + dummiesKilled;
    }
}
