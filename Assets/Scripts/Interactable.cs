using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Dialogue dialogue;
    public TextHandler textHandler;
    public bool interactedWith = false;

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Speak();
        }
    }

    public void Speak()
    {
        if (interactedWith == false)
        {
            textHandler.LoadDialogue(dialogue);
            interactedWith = true;
        }
        else
        {
            textHandler.EndOfConvo();
        }

    }
}
