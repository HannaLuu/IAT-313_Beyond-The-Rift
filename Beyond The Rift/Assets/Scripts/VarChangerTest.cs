using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class VarChangerTest : MonoBehaviour
{
    public Flowchart myFlowchart;
    private int rpValue;
    Text rpValueText;

    private void Start()
    {
        rpValueText = GetComponent<Text>();
    }

    private void Update()
    {
        rpValueText.text = "RP: " + rpValue;
        rpValue = myFlowchart.GetIntegerVariable("Var");

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            rpValue += 3;
            myFlowchart.SetIntegerVariable("Var", rpValue);
            Debug.Log("RP: " + rpValue);
        }
    }
}
