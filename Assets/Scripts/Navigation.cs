using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigation : MonoBehaviour
{
    public Room currentRoom;
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
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
            
        }
    }
}
