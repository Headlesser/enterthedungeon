using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public Room currentRoom;
    Dictionary<string, Room> exitDictionary = new Dictionary<string, Room>();
    private GameController controller;

    void Awake()
    {
        controller = GetComponent<GameController>();
    }

    public void UnpackExitsInRoom()
    {
        //Go over array of exits in current room to display on the screen
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            //adds the room's exits to the dictionary
            exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
            
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if(exitDictionary.ContainsKey(directionNoun))
        {
            //move to the next room if text was correct
            currentRoom = exitDictionary[directionNoun];
            controller.LogStringWithReturn("You go " + directionNoun);
            controller.DisplayRoomText();
            controller.DisplayRoomImage();
            controller.PlayRoomSound();
        }
        else
        {
            controller.LogStringWithReturn("You cannot go " + directionNoun);
        }
    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }
}
