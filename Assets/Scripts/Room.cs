using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/Room")]
public class Room : ScriptableObject
{
    //Scriptable Object
    //Never get attached to game objects, exist as assets and run in memory, etc.
    [TextArea]
    public string description;
    public string roomID;
    public Exit[] exits;

}
