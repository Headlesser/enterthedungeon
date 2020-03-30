using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/InputActions/ExamineRoom")]
public class ExamineRoom :InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.DisplayRoomText();
    }
}
