using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    public List<InteractableObject> usableItemList;
    //Master list of every possible usable item in the game
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();
    private Dictionary<string, ActionResponse> useDictionary = new Dictionary<string, ActionResponse>();

    //Items are either in the player's inventory, or inside of a room.
    //If something is in the inventory, do NOT display it's description in the room.
    [HideInInspector]
    public List<string> nounsInRoom = new List<string>();
    //private?
    public List<string> nounsInInventory = new List<string>();
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

    public void AddActionResponsesToUseDictionary()
    {
        //Whenever you take an item, update the 'use' dictionary.
        for (int i = 0; i < nounsInInventory.Count; i++)
        {
            string noun = nounsInInventory[i];
            //go through every noun in the inventory and get their name
            InteractableObject interactableObjectInInventory = GetInteractableObjectFromUsableList(noun);
            if(interactableObjectInInventory == null)
            {
                continue;
            }
            for (int j = 0; j < interactableObjectInInventory.interactions.Length; j++)
            {
                Interaction interaction = interactableObjectInInventory.interactions[j];
                if(interaction.actionResponse == null)
                {
                    continue;
                }
                if(!useDictionary.ContainsKey(noun))
                {
                    useDictionary.Add(noun, interaction.actionResponse);
                }
            }
        }
    }

    InteractableObject GetInteractableObjectFromUsableList(string noun)
    {
        for (int i = 0; i < usableItemList.Count; i++)
        {
            if(usableItemList[i].noun == noun)
            {
                return usableItemList[i];
            }
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
            AddActionResponsesToUseDictionary();
            nounsInRoom.Remove(noun);
            return takeDictionary;
        }
        else
        {
            controller.LogStringWithReturn("There is no " + noun + " in the room.");
            return null;
        }
    }

    public void UseItem(string[] separatedInputWords)
    {
        //Will not return a string. Text response already stored in the scriptableObject
        string nounToUse = separatedInputWords[1];
        if(nounsInInventory.Contains(nounToUse))
        {
            if(useDictionary.ContainsKey(nounToUse))
            {
                //if player has the item in their inventory and it is within the useItem dictionary
                bool actionResult = useDictionary[nounToUse].DoActionResponse(controller);
                if(!actionResult)
                {
                    controller.LogStringWithReturn("Nothing seems to happen.");
                }
            }
            else
            {
                controller.LogStringWithReturn("You cannot use the " + nounToUse);
            }  
        }
        else
        {
            controller.LogStringWithReturn("There is no " + nounToUse + " in your inventory.");
        }  
    }
}
