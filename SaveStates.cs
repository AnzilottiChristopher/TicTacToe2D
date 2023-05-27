using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveStates
{
    private int index;

    public SaveStates(int index)
    {
        this.index = index;
    }

    public void setGameObject(int index)
    {
        this.index = index;
    }

    public int getGameObject()
    {
        return this.index;
    }
}
