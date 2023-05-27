using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigBoard : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    // private GameObject gameBoard;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite != null)
        {
            spriteRenderer.sprite = null;
        }
        
    }

    private void OnMouseDown()
    {
        if (gameObject.name == "TopLeft")
        {
            SceneManager.LoadScene("TopLeft");
        }
        if (gameObject.name == "TopMid")
        {
            SceneManager.LoadScene("TopMid");
        }
        if (gameObject.name == "TopRight")
        {
            SceneManager.LoadScene("TopRight");
        }
        
        if (gameObject.name == "MidLeft")
        {
            SceneManager.LoadScene("MidLeft");
        }
        if (gameObject.name == "Mid")
        {
            SceneManager.LoadScene("Mid");
        }
        if (gameObject.name == "MidRight")
        {
            SceneManager.LoadScene("MidRight");
        }
        
        if (gameObject.name == "BottomLeft")
        {
            SceneManager.LoadScene("BottomLeft");
        }
        if (gameObject.name == "BottomMid")
        {
            SceneManager.LoadScene("BottomMid");
        }
        if (gameObject.name == "BottomRight")
        {
            SceneManager.LoadScene("BottomRight");
        }
    }
}
