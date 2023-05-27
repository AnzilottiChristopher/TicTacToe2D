using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] images;
    // Start is called before the first frame update
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = null;
        //spriteRenderer.sprite = null;
        //drawCounter = 0;
    }

    private void OnMouseDown()
    {
        //Loading Top Boards
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
        
        //Loading middle boards
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
            SceneManager.LoadScene("TopRight");
            
        }
        
        //Loading bottom boards
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
