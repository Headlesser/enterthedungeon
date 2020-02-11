using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextInput : MonoBehaviour
{
    private GameController controller;
    public TMP_InputField inputField;

    void Awake()
    {
        controller = GetComponent<GameController>();
        //call the function any time onEndEdit event occurs, eg. Presses return/enter
        inputField.onEndEdit.AddListener(AcceptStringInput);
    }
    void AcceptStringInput(string userInput)
    {
        userInput = userInput.ToLower();
        controller.LogStringWithReturn(userInput);

        //the character we will look for to separate our words is a SPACE. go ___ north.
        char[] delimiterCharacters = {' '};
        string[] separatedInputWords = userInput.Split(delimiterCharacters);
        //check the array of input words with matching keyword
        for (int i = 0; i < controller.inputActions.Length; i++)
        {
            InputAction inputAction = controller.inputActions[i];
            if (inputAction.keyWord == separatedInputWords[0])
            {
                inputAction.RespondToInput(controller, separatedInputWords);
            }
        }

        InputComplete();
    }

    void InputComplete()
    {
        controller.DisplayLoggedText();
        inputField.ActivateInputField();
        inputField.text = null;
    }
}
