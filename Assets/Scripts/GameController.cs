using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{

    public TMP_Text displayText;
    public InputAction[] inputActions;

    [HideInInspector]
    public Navigation roomNavigation;
    [HideInInspector]
    public List<string> interactionDescriptionsInRoom = new List<string>();
    [HideInInspector]
    public InteractableItems interactableItems;

    List<string> actionLog = new List<string>();

    public Image roomImage;

    void Awake()
    {
        interactableItems = GetComponent<InteractableItems>();
        roomNavigation = GetComponent<Navigation>();
    }

    void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
        DisplayRoomImage();
    }

    public void DisplayLoggedText()
    {
        //Displays everything in the action log currently.
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
    }

    public void DisplayRoomText()
    {
        ClearCollectionsForNewRoom();
        UnpackRoom();

        string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());

        //Displays Room's individual text.
        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
    }

    public void DisplayRoomImage()
    {
        roomImage.sprite = roomNavigation.currentRoom.sprite;
    }

    void UnpackRoom()
    {
        //'loads' the new room
        roomNavigation.UnpackExitsInRoom();
        PrepareObjectsToTakeOrExamine(roomNavigation.currentRoom);
    }

    void PrepareObjectsToTakeOrExamine(Room currentRoom)
    {
        for (int i = 0; i < currentRoom.interactableObjectsInRoom.Length; i++)
        {
            //go over the array of objects in the room to display their descriptions
            //get referance to InteractableItems script
            string descriptionNotInInventory = interactableItems.GetObjectsNotInInventory(currentRoom,i);
            if(descriptionNotInInventory != null)
            {
                //if loop succeeded and something WAS found inside of the room
                interactionDescriptionsInRoom.Add(descriptionNotInInventory);
            }
            InteractableObject interactableInRoom = currentRoom.interactableObjectsInRoom[i];

            for (int j = 0; j < interactableInRoom.interactions.Length; j++)
            {
                //first loop gets all the interactabe objects. 
                //Second loop --> on each object, loop over its individual interactions
                Interaction interaction = interactableInRoom.interactions[j];
                if(interaction.inputAction.keyWord == "examine")
                {
                    //if the player types the examine keyword...
                    //add it to examine dictionary. For example, if you pass in "Rusty Key", return the text response for it.
                    interactableItems.examineDictionary.Add(interactableInRoom.noun, interaction.textResponse);
                }
            }
        }
    }

    public string TextVerbDictionaryWithNoun(Dictionary<string, string> verbDictionary, string verb, string noun)
    {
        //check if the noun the player examines is in the dictionary. if it is, display text.
        //otherwise, give negative response
        if(verbDictionary.ContainsKey(noun))
        {
            return verbDictionary[noun];
        }
        else
        {
            return "You cannot " + verb + " " + noun + ".";
        }
    }

    void ClearCollectionsForNewRoom()
    {
        //'Clear' all the lists/dictionaries so they can be repopulated with
        //the information stored with the next room
        interactableItems.ClearCollections();
        interactionDescriptionsInRoom.Clear();
        roomNavigation.ClearExits();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }
}
