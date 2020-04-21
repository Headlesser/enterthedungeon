using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItems : MonoBehaviour
{
    public List<InteractableObject> usableItemList;
    //Master list of every possible usable item in the game
    public Dictionary<string, string> examineDictionary = new Dictionary<string, string>();
    public Dictionary<string, string> takeDictionary = new Dictionary<string, string>();
    //public Dictionary<string, ActionResponse> takeDictionaryAction = new Dictionary<string, ActionResponse>();
    public Dictionary<string, string> useDictionaryResponse = new Dictionary<string, string>();
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
        
        if(nounsInRoom.Contains(noun) && !GetInteractableObjectFromUsableList(noun).canNotTake)
        {
            //if the item is in the room, add it to inventory, remove it from ROOM. This keeps you 
            //from being able to examine an object you have already taken should you backtrack.
            //also change the room's image?
            nounsInInventory.Add(noun);
            AddActionResponsesToUseDictionary();
            ChangeImage(noun);
            nounsInRoom.Remove(noun);
            //controller.roomNavigation.currentRoom.interactableObjectsInRoom.Remove(FindObjectToRemove(separatedInputWords));
            //Debug.Log("Remove the item from the room list");

            //AddActionResponsesToTakeActions();
            //takeDictionaryAction[nounToUse].DoActionResponse(controller, separatedInputWords);
            //PROBLEM --> After doing a take action response, the USE action response no longer works? Fuck it.
            return takeDictionary;
        }
        else
        {
            controller.LogStringWithReturn("You cannot take " + noun + ".");
            return null;
        }
    }

    public void ChangeImage(string noun)
    {
        //Debug.Log("begin change image...");
        //check it the old fashioned way. If the noun given was taken, change the current room's sprite value
        //ONLY IF that object is supposed to.
        InteractableObject target = GetInteractableObjectFromUsableList(noun);
        //Debug.Log(target + " This is the object found.");
        if(target.changeSprite == true)
        {
            //Debug.Log("This object is set to true to switch images");
            controller.roomNavigation.currentRoom.sprite = target.changeTo;
            controller.DisplayRoomImage();
            //Debug.Log("Change the image.");
        }
    }

    //This works, but means I have to reassign the lists every time I play the game.
    //Also, to make sure an object doesn't 'respawn' after being used, it must have an 'open' version of the room where that item does not exist.
    //As soon as all items/secrets required to open the TRUNK room are gotten, seal all other exits from the final version of that room.

    // private InteractableObject FindObjectToRemove(string[] separatedInputWords)
    // {
    //     for (int i = 0; i < controller.roomNavigation.currentRoom.interactableObjectsInRoom.Count; i++)
    //     {
    //         InteractableObject interactableObjectInRoom = controller.roomNavigation.currentRoom.interactableObjectsInRoom[i];
    //         if(interactableObjectInRoom.noun == separatedInputWords[1])
    //         {
    //             return interactableObjectInRoom;
    //         }
    //     }
    //     return null;
    // }

    public void UseItem(string[] separatedInputWords)
    {
        //Will not return a string. Text response already stored in the scriptableObject
        string nounToUse = separatedInputWords[1];
        if(nounsInInventory.Contains(nounToUse))
        {
            if(useDictionary.ContainsKey(nounToUse))
            {
                //if player has the item in their inventory and it is within the useItem dictionary
                bool actionResult = useDictionary[nounToUse].DoActionResponse(controller, separatedInputWords);
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
