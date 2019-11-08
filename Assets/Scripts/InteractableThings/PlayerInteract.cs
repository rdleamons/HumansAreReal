using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject Evidence = null;
    public GameObject NPC = null;
    public Text countText;
    public Text winText;

    public int evidenceCount = 0;

    private void Start()
    {
        SetCountText();
        winText.text = "";
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("evidenceCount", evidenceCount);
    }
    private void Update()
    {
        if(Input.GetButtonDown("Interact") && Evidence)
        {
            //Do something w/ object
            //Evidence.SendMessage("DoInteraction");

            evidenceCount++;
            PlayerPrefs.SetInt("evidenceCount", evidenceCount);
            SetCountText();

            //Makes Evidence dissappear
            Evidence.SetActive(false);

            //Win screen
            if(evidenceCount >= 4)
            {
                winText.text = "Congrats! You've gathered enough evidence!";
                //Load "you win!" menu
            }
        }else if(Input.GetButtonDown("Interact") && NPC)
        {
            //Make text appear
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Evidence"))
        {
            Debug.Log(collision.name);
            Evidence = collision.gameObject;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject == Evidence)
        {
            Evidence = null;
        }
    }

    void SetCountText()
    {
        evidenceCount = PlayerPrefs.GetInt("evidenceCount", 0);
        countText.text = "Evidence Gathered: " + evidenceCount.ToString();
    }
}
