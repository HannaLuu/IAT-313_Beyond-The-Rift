using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;



public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    public Variable variable;

    // Load scene based on string
    public void FuckScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
