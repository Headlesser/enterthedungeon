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

    List<string> actionLog = new List<string>();

    public Image roomImage;

    void Awake()
    {
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
        roomNavigation.UnpackExitsInRoom();
    }

    void ClearCollectionsForNewRoom()
    {
        interactionDescriptionsInRoom.Clear();
        roomNavigation.ClearExits();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }
}
