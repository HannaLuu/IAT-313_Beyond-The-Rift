using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeAll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void freezeAll()
    {
        Time.timeScale = 0;
    }

    public void unfreezeAll()
    {
        Time.timeScale = 1;
    }
}
