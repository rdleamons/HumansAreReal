using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialougeTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("NPC"))
        {
            if(Input.GetKeyDown("Interact"))
            {
                TriggerDialogue();
            }
        }
    }
    public void TriggerDialogue()
    {
        FindObjectOfType<DialougeManager>().StartDialogue(dialogue);
    }
}
