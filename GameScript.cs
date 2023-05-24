using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{
    int spriteIndex = -1;

    public int playerTurn()
    {
        spriteIndex++;
        return spriteIndex % 2;
    }
}
