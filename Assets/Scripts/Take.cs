using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Text Adventure/InputActions/Take")]
public class Take : InputAction
{ 
    public override void RespondToInput(GameController controller, string[] separatedInputWords)
    {
        //attempt to take something
        Dictionary<string, string> takeDictionary = controller.interactableItems.Take(separatedInputWords);
        
        if(takeDictionary != null)
        {
            //if the dictionary is not null
            controller.LogStringWithReturn(controller.TextVerbDictionaryWithNoun(takeDictionary, separatedInputWords[0], separatedInputWords[1]));
        }
    }
}
