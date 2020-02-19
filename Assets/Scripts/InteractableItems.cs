using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();
    //Items are either in the player's inventory, or inside of a room.
    //If something is in the inventory, do NOT display it's description in the room.
    [HideInInspector]
    public List<string> nounsInRoom = new List<string>();
    //private?
    private List<string> nounsInInventory = new List<string>();
    GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();
    }
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

    public void DisplayInventory()
    {
        controller.LogStringWithReturn("In your pockets you have: ");
        for (int i = 0; i < nounsInInventory.Count; i++)
        {
            controller.LogStringWithReturn(nounsInInventory[i]);
        }
    }

    public void ClearCollections()
    {
        //Clear all entries in dictionary when moving to the next room
        //Because those items will no longer be present in the new room
        examineDictionary.Clear();
        takeDictionary.Clear();
        nounsInRoom.Clear();
    }

    public Dictionary<string, string> Take(string[] separatedInputWords)
    {
        string noun = separatedInputWords[1];
        
        if(nounsInRoom.Contains(noun))
        {
            //if the item is in the room, add it to inventory, remove it from ROOM. This keeps you 
            //from being able to examine an object you have already taken should you backtrack.
            nounsInInventory.Add(noun);
            nounsInRoom.Remove(noun);
            return takeDictionary;
        }
        else
        {
            controller.LogStringWithReturn("There is no " + noun + " in the room.");
            return null;
        }
    }
}
