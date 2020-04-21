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

    public AudioSource audioSource;
    public AudioSource actionAudioSource;
    public float textDelay;
    public bool typewriterText;

    void Awake()
    {
        typewriterText = false;
        interactableItems = GetComponent<InteractableItems>();
        roomNavigation = GetComponent<Navigation>();
        audioSource = GetComponent<AudioSource>();
        actionAudioSource = GetComponentInChildren<AudioSource>();
    }

    void Start()
    {
        DisplayRoomText();
        if(typewriterText)
        {
            StartCoroutine(DisplayLoggedTextType());
        }
        if(!typewriterText)
        {
            DisplayLoggedText();
        }
        DisplayRoomImage();
        PlayRoomSound();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void DisplayControls()
    {
        string movement ="'go' + direction (north, south, east, west) to move between rooms";
        string take = "'take' + item to add item to your inventory";
        string examine = "'examine' + item to look closely at object";
        string use = "'use' + item to use an item";
        string inventory = "'inventory' to open inventory";
        string room = "'room' to display the room description again";
        string quit = "'quit' to quit the game (CAUTION: You cannot escape without consequences!)";
        string help = "'help' to display controls";
        LogStringWithReturn(movement + "\n" + examine + "\n" + take + "\n" + use + "\n" + inventory + "\n" + room + "\n" + quit + "\n" + help);
    }

    public void DisplayLoggedText()
    {
        //Displays everything in the action log currently.
        string logAsText = string.Join("\n", actionLog.ToArray());
        displayText.text = logAsText;
        //StartCoroutine(ScrollToTop());
    }

    // IEnumerator ScrollToTop() //Keep the bar scrolled to the very bottom.
    // {
    //     yield return new WaitForEndOfFrame();
    //     Canvas.ForceUpdateCanvases();
    //     scrollRect.verticalNormalizedPosition = 0f; 
    //     Canvas.ForceUpdateCanvases();    
    // }

    //Replaces DisplayLoggedText();
    //https://www.youtube.com/watch?v=1qbjmb_1hV4&t=442s
    public IEnumerator DisplayLoggedTextType()
    {
        //Currently set up so it just prints out the entire action log again. 
        //We want it to ONLY print out what did not exist in the previous log. That is --> Only the newest lines.
        string logAsText = string.Join("\n", actionLog.ToArray());
        for (int i = 0; i < logAsText.Length; i++)
        {
            displayText.text = logAsText.Substring(0, i);
            yield return new WaitForSeconds(textDelay);
        }
    }

    public void EmptyTextLog()
    {
        //Call to clear out all text from the action log. Do this after entering a new SECTION.
        actionLog.Clear();
    }

    public void DisplayAllRoomText()
    {
        //For the 'room' input action. Displays room text, and items within the room.
        string joinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());

        //Displays Room's individual text.
        string combinedText = roomNavigation.currentRoom.description + "\n" + joinedInteractionDescriptions;

        LogStringWithReturn(combinedText);
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

    public void StopRoomSound()
    {
        audioSource.Stop();
    }

    public void PlayRoomSound()
    {
        //Set the audio clip to play to the room's audio clip
        //Debug.Log(roomNavigation.currentRoom.audio);
        audioSource.clip = roomNavigation.currentRoom.audio;
        audioSource.Play();
    }

    void UnpackRoom()
    {
        //'loads' the new room
        PrepareObjectsToTakeOrExamine(roomNavigation.currentRoom);
        roomNavigation.UnpackExitsInRoom();
    }

    void PrepareObjectsToTakeOrExamine(Room currentRoom)
    {
        for (int i = 0; i < currentRoom.interactableObjectsInRoom.Length; i++)
        {
            //go over the array of objects in the room to display their descriptions
            //get reference to InteractableItems script
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
                //Second loop --> on each object, loop over its individual interactions (examine, take, use)
                Interaction interaction = interactableInRoom.interactions[j];
                //Interactions are JUST the names and descriptions of the objects in the room.
                //This isn't what you want to remove
                if(interaction.inputAction.keyWord == "examine")
                {
                    //if the player types the examine keyword...
                    //add it to examine dictionary. For example, if you pass in "Key", return the text response for it.
                    interactableItems.examineDictionary.Add(interactableInRoom.noun, interaction.textResponse);
                }
                if(interaction.inputAction.keyWord == "take" && !interactableInRoom.canNotTake)
                {
                    //Debug.Log("Took an item, delete it from the room's list");
                    //if the player types the take keyword...
                    //add it to take dictionary 
                    //Remember, the takeDictionary IS your Inventory Dictionary!
                    interactableItems.takeDictionary.Add(interactableInRoom.noun, interaction.textResponse);
                }
                if(interaction.inputAction.keyWord == "use" && !interactableItems.useDictionaryResponse.ContainsKey(interactableInRoom.noun)) //this is the error line. don't add to the dictionary if its already in it
                {
                    interactableItems.useDictionaryResponse.Add(interactableInRoom.noun, interaction.textResponse);
                    //delete item from room interactableobjects array/list
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
