using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

   private void OnEnable()
   {
      spriteRenderer.sprite = null;
   }

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
         string winner = gameBoard.GetComponent<GameScript>().winCondition();
         if (winner == "x")
         {
            //Debug.Log("Game Over");
            GameOver.playerXWin();
         }
         else if (winner == "o")
         {
            GameOver.playerOWin();
         }
         else if (gameBoard.GetComponent<GameScript>().getDrawCounter() == 9)
         {
            GameOver.draw();
         }
         
         //Debug.Log(spot);
         unplayed = false;
      }
   }

   private void Awake()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      gameBoard = GameObject.Find("GameBoard");
      
   }
}
