using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SpriteState")]

public class SpriteState : ScriptableObject
{
    [SerializeField]
    private int[] index = new int[9];
    
    public void setIndex(int spriteState, GameObject location, bool unplayable)
    {
        //This should set the sprite index value
        if (location.name == "Token1")
        {
            index[0] = spriteState;
        }
        if (location.name == "Token2")
        {
            index[1] = spriteState;
        }
        if (location.name == "Token3")
        {
            index[2] = spriteState;
        }
        
        if (location.name == "Token4")
        {
            index[3] = spriteState;
        }
        if (location.name == "Token5")
        {
            index[4] = spriteState;
        }
        if (location.name == "Token6")
        {
            index[5] = spriteState;
        }
        
        if (location.name == "Token7")
        {
            index[6] = spriteState;
        }
        if (location.name == "Token8")
        {
            index[7] = spriteState;
        }
        if (location.name == "Token9")
        {
            index[8] = spriteState;
        }
    }

    public int getIndex(GameObject location)
    {
        //this should return the correct index value based on the gameObject 
        //Could be noted that this part may be unnecessary, however, I don't know how this really works 
        if (location.name == "Token1")
        {
            return index[0];
        }
        if (location.name == "Token2")
        {
            return index[1];
        }
        if (location.name == "Token3")
        {
            return index[2];
        }
        
        if (location.name == "Token4")
        {
            return index[3];
        }
        if (location.name == "Token5")
        {
            return index[4];
        }
        if (location.name == "Token6")
        {
            return index[5];
        }
        
        if (location.name == "Token7")
        {
            return index[6];
        }
        if (location.name == "Token8")
        {
            return index[7];
        }
        if (location.name == "Token9")
        {
            return index[8];
        }

        return -1;
    }

}
