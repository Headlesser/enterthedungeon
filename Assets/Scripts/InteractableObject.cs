using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/Interactable Object")]
public class InteractableObject : ScriptableObject
{

    public string noun = "name";
    [TextArea]
    public string description = "Description of item in the room";
    public Interaction[] interactions;
    public bool changeSprite; //This variable is ONLY true if the item needs to have its image changed
    public bool canNotTake;

    public Sprite changeTo; //This variable is ONLY used if the particular item needs to have an image changed

}
