using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/ActionResponses/ChangeRoom")]
public class ChangeRoomResponse : ActionResponse
{
    public Room roomToChangeTo;
    //If you use item in correct place
    //it will 'change' you to a 'new' room where the secret door is open.
    //Think of it more like creating a room that is a copy of the current one, but
    //with the new entrance/exit.
    public AudioClip actionSound;
    //The sound to play after performing the use action.

    public override bool DoActionResponse(GameController controller, string[] separatedInputWords)
    {
        if(controller.roomNavigation.currentRoom.roomID == requiredString)
        {
            controller.roomNavigation.currentRoom = roomToChangeTo;
            controller.LogStringWithReturn(controller.TextVerbDictionaryWithNoun(controller.interactableItems.useDictionaryResponse, separatedInputWords[0], separatedInputWords[1]));
            controller.interactableItems.nounsInInventory.Remove(separatedInputWords[1]);
            controller.DisplayRoomText();
            controller.DisplayRoomImage();
            controller.PlayRoomSound();

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
