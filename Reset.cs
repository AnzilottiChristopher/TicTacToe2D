using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    private void OnMouseDown()
    {
        //SceneManager.UnloadSceneAsync("MainScene");
        if (gameObject.name == "Yes")
        {
            SceneManager.LoadScene("MainScene");
        }
        else if (gameObject.name == "No")
        {
            Application.Quit();
        }
    }
}
