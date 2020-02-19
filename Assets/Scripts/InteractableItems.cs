﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    //Items are either in the player's inventory, or inside of a room.
    //If something is in the inventory, do NOT display it's description in the room.
    [HideInInspector]
    public List<string> nounsInRoom = new List<string>();
    private List<string> nounsInInventory = new List<string>();
    public string GetObjectsNotInInventory(Room currentRoom, int i)
    {
        InteractableObject interactableInRoom = currentRoom.interactableObjectsInRoom[i];
        //either add to the room list or don't
        if(!nounsInInventory.Contains(interactableInRoom.noun))
        {
            //not in the inventory, display in the room
            nounsInRoom.Add(interactableInRoom.noun);
            return interactableInRoom.description;
        }

        return null;
    }

    public void ClearCollections()
    {
        //Clear all entries in dictionary when moving to the next room
        //Because those items will no longer be present in the new room
        examineDictionary.Clear();
        nounsInRoom.Clear();
    }
}
