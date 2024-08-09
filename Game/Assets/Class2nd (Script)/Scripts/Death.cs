using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Message
{
    public string Bear;

    public Message(string death)
    {
        this.Bear = death;
    }
}

public class Death : MonoBehaviour
{
    Message message = new Message("Bear");

    void Start()
    {
        Debug.Log(message + "Death");
    }


    void Update()
    {
        
    }
}
