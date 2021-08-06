using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;

    // Load scene based on string
    public void FuckScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
