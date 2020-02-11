using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Text Adventure/Room")]
public class Room : ScriptableObject
{
    //Scriptable Object
    //Never get attached to game objects, exist as assets and run in memory, etc.
    [TextArea]
    public string description;
    public string roomID;
    public Exit[] exits;
    public Sprite sprite;
    //Make it so this variable stores the 'image' of the room. Will change as player moves to 
    //different rooms.

}
