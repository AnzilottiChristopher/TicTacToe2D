using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurnScript : MonoBehaviour
{
   private SpriteRenderer spriteRenderer;
   public Sprite[] images;
   private GameObject gameBoard;
   private bool unplayed = true;
   //private int drawCounter;

   private void Start()
   {
      spriteRenderer.sprite = null;
      //drawCounter = 0;
   }

   // private void OnEnable()
   // {
   //    spriteRenderer.sprite = null;
   // }

   private void OnMouseDown()
   {
      if (unplayed)
      {
         int index = gameBoard.GetComponent<GameScript>().playerTurn();
         spriteRenderer.sprite = images[index];
         // drawCounter++;
         // Debug.Log(drawCounter);
         GameObject spot = gameObject;
         gameBoard.GetComponent<GameScript>().fillBoard(spot, index);
         // string winner = gameBoard.GetComponent<GameScript>().winCondition();
         // if (winner == "x")
         // {
         //    //Debug.Log("Game Over");
         //    GameOver.playerXWin();
         // }
         // else if (winner == "o")
         // {
         //    GameOver.playerOWin();
         // }
         // else if (gameBoard.GetComponent<GameScript>().getDrawCounter() == 9)
         // {
         //    GameOver.draw();
         // }
         
         //Debug.Log(spot);
         unplayed = false;
         switchScenes();
      }
   }

   private void switchScenes()
   {
      if (gameObject.name == "Token1")
      {
         SceneManager.LoadScene("TopLeft");
      }
      if (gameObject.name == "Token2")
      {
         SceneManager.LoadScene("TopMid");
      }
      if (gameObject.name == "Token3")
      {
         SceneManager.LoadScene("TopRight");
      }
        
      if (gameObject.name == "Token4")
      {
         SceneManager.LoadScene("MidLeft");
      }
      if (gameObject.name == "Token5")
      {
         SceneManager.LoadScene("Mid");
      }
      if (gameObject.name == "Token6")
      {
         SceneManager.LoadScene("MidRight");
      }
        
      if (gameObject.name == "Token7")
      {
         SceneManager.LoadScene("BottomLeft");
      }
      if (gameObject.name == "Token8")
      {
         SceneManager.LoadScene("BottomMid");
      }
      if (gameObject.name == "Token9")
      {
         SceneManager.LoadScene("BottomRight");
      }
   }

   private void Awake()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      gameBoard = GameObject.Find("GameBoard");
      
   }
}
