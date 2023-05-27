using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
   private SpriteRenderer spriteRenderer;
   public Sprite[] images;
   
   [SerializeField]
   private GameObject gameBoard;
   private bool unplayed = true;
   
   [SerializeField]
   private SpriteState spriteState;
   //private int drawCounter;

   private void Start()
   {
      //spriteState = new SpriteState();
      //ScriptableObject.CreateInstance("SpriteState");
      gameObject.GetComponent<SpriteRenderer>().sprite = null;
      //spriteRenderer.sprite = null;
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

         gameObject.GetComponent<SpriteRenderer>().sprite = images[index];
         //spriteRenderer.sprite = images[index];
         // drawCounter++;
         // Debug.Log(drawCounter);
         GameObject spot = gameObject;
         
         spriteState.setIndex(index, gameObject, false);
         //Debug.Log(spriteState.getIndex(gameObject));
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
         gameBoard.GetComponent<GameScript>().fillBoard(spot, index);

         
      }
   }

   private void Awake()
   {
      gameObject.GetComponent<SpriteRenderer>().sprite = images[spriteState.getIndex(gameObject)];
   }
}
