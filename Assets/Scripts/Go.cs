using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName="Text Adventure/InputActions/Go")]
public class Go : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        //pass in the SECOND word because we use noun->verb format 'go NORTH', 'take KEY'
        controller.roomNavigation.AttemptToChangeRooms(separatedInputWords[1]);
    }
}
