using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/InputActions/Quit")]
public class Quit : InputAction
{
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        controller.Quit();
    }

}
