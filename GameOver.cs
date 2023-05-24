using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameOver 
{
    public static void playerXWin()
    {
        SceneManager.LoadScene("PlayerXWin");
    }

    public static void playerOWin()
    {
        SceneManager.LoadScene("PlayerOWin");
    }
}
