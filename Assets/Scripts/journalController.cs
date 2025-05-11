using TMPro;
using UnityEngine.UI;
using UnityEngine;

//Title: Unity 2D Tutorial How To Pick Up An Item Pressing Specific Button. Pop Up Sign Hit ‘E’ To Pick Up.
//Author: Alexander Zotov
//Date: 20 April 2025
//Code Version: Unity 2018.1.0f2
//Availability: https://www.youtube.com/watch?v=yFKg8qVclBk&t=3s

//Title: Pick Up Items On Collision - Beginner Unity 2D
//Author: Game Code Library
//Date: 20 April 2025
//Code Version: Unity 2021.3.23f1
//Availability: https://www.youtube.com/watch?v=2tarnsQGzac&t=39s

public class journalController : MonoBehaviour
{
    [SerializeField] private Image journalText;
    
    void Start()
    {
        journalText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            journalText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            journalText.gameObject.SetActive(false);
        }
    }
}
