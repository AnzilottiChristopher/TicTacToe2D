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

   private void Start()
   {
      spriteRenderer.sprite = null;
   }

   private void OnMouseDown()
   {
      if (unplayed)
      {
         int index = gameBoard.GetComponent<GameScript>().playerTurn();
         spriteRenderer.sprite = images[index];
         GameObject spot = gameObject;
         gameBoard.GetComponent<GameScript>().fillBoard(spot, index);
         
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
