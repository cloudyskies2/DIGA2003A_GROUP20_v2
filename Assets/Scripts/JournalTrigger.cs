using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

//Title: Journal UI Trigger Interaction Script
//Author: ChatGPT (OpenAI Assistant)
//Date: 16 June 2025
//Code Version: GPT-4o
//Availability: Generated through OpenAI's ChatGPT platform (https://chat.openai.com/)

public class JournalTrigger : MonoBehaviour
{

    public GameObject journalPanel;
    public TextMeshProUGUI promptText;

    private bool isPlayerInRange = false;
    private bool isJournalOpen = false;

    private void Update()
    {

        if (isPlayerInRange)
        {

            if (Input.GetKeyDown(KeyCode.E) && !isJournalOpen)
            {

                journalPanel.SetActive(true);
                isJournalOpen = true;
                promptText.gameObject.SetActive(false);

            }//ifinrange

            if (isJournalOpen && Input.GetKeyDown(KeyCode.R))
            {
                journalPanel.SetActive(false);
                isJournalOpen = false;
            }


        }

    }//update void

       private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
            promptText.gameObject.SetActive(true);

        }

    }//TrigEnt

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
            promptText.gameObject.SetActive(false);
        }
    }


}//class


