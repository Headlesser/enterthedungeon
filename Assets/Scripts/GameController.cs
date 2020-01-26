using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    [HideInInspector]
    public Navigation roomNavigate;

    void Awake()
    {
        roomNavigate = GetComponent<Navigation>();
    }

    public void DisplayRoomText()
    {
        string combinedText = roomNavigate.currentRoom.description + "\n";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
