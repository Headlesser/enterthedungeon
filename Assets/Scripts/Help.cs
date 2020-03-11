using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/InputActions/Help")]
public class Help : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.DisplayControls();
    }
}
