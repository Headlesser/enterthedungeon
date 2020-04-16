using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/ActionResponses/ChangeImage")]
public class ChangeRoomImage : ActionResponse
{
    public Sprite changeImageTo;
    public AudioClip actionSound;
    //The sound to play after performing the use action.

    public override bool DoActionResponse(GameController controller, string[] separatedInputWords)
    {
        if(controller.roomNavigation.currentRoom.roomID == requiredString)
        {
            controller.roomNavigation.currentRoom.sprite = changeImageTo; //problem, does not reset the images to their original ones after testing.
            controller.LogStringWithReturn(controller.TextVerbDictionaryWithNoun(controller.interactableItems.takeDictionary, separatedInputWords[0], separatedInputWords[1]));
            controller.DisplayRoomText();
            controller.DisplayRoomImage();
            Debug.Log("Took the item, change the image");

            if(actionSound != null)
            {
                controller.actionAudioSource.PlayOneShot(actionSound);
                //actionSound = null; to remove the old sound? 
                //Plays the 'activation' sound ONCE.
                //This will only be for the 'use' functionality
                //Things such as jingling of key, scraping gargoyle statue, etc. Stuff that indicates 'that input was successful'
                //Put within a != null statement in case any room happens to not have an audio clip.
            }
            return true;
        }
        return false;
    }

}
