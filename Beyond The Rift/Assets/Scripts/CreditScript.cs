using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMenu()
    {
        SceneManager.LoadScene("Intro Video");
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Start");
        }
    }
}
