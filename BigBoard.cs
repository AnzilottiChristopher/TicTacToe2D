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
    
    public void SaveObjectState(SaveStates state)
    {
        // Convert the object state to JSON
        string json = JsonUtility.ToJson(state);

        // Save the JSON string to a file or PlayerPrefs
        // Example using PlayerPrefs:
        PlayerPrefs.SetString("ObjectState", json);
    }
    
    public SaveStates LoadObjectState()
    {
        // Load the JSON string from the saved file or PlayerPrefs
        string json = PlayerPrefs.GetString("ObjectState", string.Empty);

        if (!string.IsNullOrEmpty(json))
        {
            // Convert the JSON string back to an ObjectState object
            SaveStates state = JsonUtility.FromJson<SaveStates>(json);
            return state;
        }

        // If no saved data found, return a default ObjectState object or null
        return null;
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
