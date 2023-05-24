using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    private int spriteIndex = -1;
    private int[,] winBoard = new int [3, 3];
    private int drawCounter;


    private void Start()
    {
        setBoard();
        drawCounter = 0;
    }

    private void setBoard()
    {
        for (int index1 = 0; index1 < 3; index1++)
        {
            for (int index2 = 0; index2 < 3; index2++)
            {
                this.winBoard[index1, index2] = 3;
            }
        }
    }
    public string winCondition()
    {
        //Initializing counters
        int xCounter = 0;
        int oCounter = 0;
        
        //Debug.Log(winBoard.Length);
        //Loop checks horizontal
        for (int index1 = 0; index1 < winBoard.GetLength(1); index1++)
        {
            for (int index2 = 0; index2 < winBoard.GetLength(0); index2++)
            {
                //Debug.Log(winBoard.GetLength(index1));
                if (winBoard[index1, index2] == 0) 
                {
                    xCounter++;
                }
                else if (winBoard[index1, index2] == 1)
                {
                    oCounter++;
                }
            }
            //If there are 3 X's in a row break out of the for loop
            if(xCounter == 3)
            {
                break;
            }

            if (oCounter == 3)
            {
                break;
            }
            //Making counter 0 again if there aren't 3 X's in a row
            xCounter = 0;
            oCounter = 0;
        }
        
        if (xCounter == 3)
        {
            //Debug.Log("Player X wins");
            return "x";
        }
        else if (oCounter == 3)
        {
            //Debug.Log("Player O wins");
            return "o";
        }


        //loop checks the vertical
        for (int index1 = 0; index1 < winBoard.GetLength(1); index1++)
        {
            for (int index2 = 0; index2 < winBoard.GetLength(0); index2++)
            {
                if (winBoard[index2, index1] == 0)
                {
                    xCounter++;
                }
                else if (winBoard[index2, index1] == 1)
                {
                    oCounter++;
                }
            }
            //If there are 3 X's in a row break out of the for loop
            if(xCounter == 3)
            {
                break;
            }

            if (oCounter == 3)
            {
                break;
            }
            //Making counter 0 again if there aren't 3 X's in a row
            xCounter = 0;
            oCounter = 0;
        }
        
        //Checking the diagonals
        if((winBoard[0,0] == 0 && winBoard[1,1] == 0 && winBoard[2,2] == 0) || (winBoard[0,2] == 0 && 
               winBoard[1,1] == 0 && winBoard[2,0] == 0))
        {
            xCounter = 3;
        }
        if((winBoard[0,0] == 1 && winBoard[1,1] == 1 && winBoard[2,2] == 1) || (winBoard[0,2] == 1 && 
               winBoard[1,1] == 1 && winBoard[2,0] == 1))
        {
            oCounter = 3;
        }

        if (xCounter == 3)
        {
            //Debug.Log("Player X wins");
            return "x";
        }
        else if (oCounter == 3)
        {
            //Debug.Log("Player O wins");
            return "o";
        }
        else
        {
            xCounter = 0;
            oCounter = 0;
            return "continue";
        }
        
    }

    public int playerTurn()
    {
        spriteIndex++;
        drawCounter++;
        return spriteIndex % 2;
    }

    public int getDrawCounter()
    {
        return drawCounter;
    }

    public void fillBoard(GameObject spot, int index)
    {
        //First Row
        if (spot.name == "Token1" && index == 0) 
        {
            winBoard[0, 0] = 0;
        }
        if (spot.name == "Token1" && index == 1) 
        {
            winBoard[0, 0] = 1;
        }
       
        if (spot.name == "Token2" && index == 0) 
        {
            winBoard[0, 1] = 0;
        }
        if (spot.name == "Token2" && index == 1) 
        {
            winBoard[0, 1] = 1;
        }
        
        if (spot.name == "Token3" && index == 0) 
        {
            winBoard[0, 2] = 0;
        }
        if (spot.name == "Token3" && index == 1) 
        {
            winBoard[0, 2] = 1;
        }
        
        //Middle Row
        if (spot.name == "Token4" && index == 0) 
        {
            winBoard[1, 0] = 0;
        }
        if (spot.name == "Token4" && index == 1) 
        {
            winBoard[1, 0] = 1;
        }
       
        if (spot.name == "Token5" && index == 0) 
        {
            winBoard[1, 1] = 0;
        }
        if (spot.name == "Token5" && index == 1) 
        {
            winBoard[1, 1] = 1;
        }
        
        if (spot.name == "Token6" && index == 0) 
        {
            winBoard[1, 2] = 0;
        }
        if (spot.name == "Token6" && index == 1) 
        {
            winBoard[1, 2] = 1;
        }
        
        //Last Row
        if (spot.name == "Token7" && index == 0) 
        {
            winBoard[2, 0] = 0;
        }
        if (spot.name == "Token7" && index == 1) 
        {
            winBoard[2, 0] = 1;
        }
       
        if (spot.name == "Token8" && index == 0) 
        {
            winBoard[2, 1] = 0;
        }
        if (spot.name == "Token8" && index == 1) 
        {
            winBoard[2, 1] = 1;
        }
        
        if (spot.name == "Token9" && index == 0) 
        {
            winBoard[2, 2] = 0;
        }
        if (spot.name == "Token9" && index == 1) 
        {
            winBoard[2, 2] = 1;
        }
    }
}
