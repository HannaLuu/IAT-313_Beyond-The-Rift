using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class VarChangerTest : MonoBehaviour
{
    public Flowchart myFlowchart;
    private static int rpValue;
    Text rpValueText;

    private void Start()
    {
        rpValueText = GetComponent<Text>();
    }

    public VarChangerTest()
    {

    }

    private void Update()
    {
        // if (isDead == true)
        // {
        //     updateRP();
        // }
    }

    public virtual void updateRP()
    {
        rpValueText.text = "RP: " + rpValue;
        rpValue = myFlowchart.GetIntegerVariable("Var");
        rpValue += 3;
        myFlowchart.SetIntegerVariable("Var", rpValue);
        Debug.Log("RP: " + rpValue);
    }
}
