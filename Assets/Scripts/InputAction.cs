using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction : ScriptableObject
{

    public string keyWord;
    //Add sound clip when an action occurs? Function that plays the sound if value is not null (some actions might not need audio)

    public abstract void RespondToInput(GameController controller, string[] separatedInputWords);
}
