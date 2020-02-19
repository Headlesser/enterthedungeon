using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Interaction 
{
    //Input actions are like "GO" or "TAKE" or "EXAMINE"
    public InputAction inputAction;
    [TextArea]
    public string textResponse;
    public ActionResponse actionResponse;
}
