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

    public override bool DoActionResponse(GameController controller)
    {
        if(controller.roomNavigation.currentRoom.roomID == requiredString)
        {
            controller.roomNavigation.currentRoom = roomToChangeTo;
            controller.DisplayRoomText();
            return true;
        }
        return false;
    }
}
