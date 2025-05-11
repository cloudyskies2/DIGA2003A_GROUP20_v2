using UnityEngine;
//using TMPro;

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

//Title: MAKE PLAYER PICK UP ITEMS IN UNITY ?? | How To Pick Up 2D Game Objects In Unity | Unity Tutorial
//Author: Dani Krossing
//Date: 21 April 2025
//Code Version: Unity 2020.3.13f1
//Availability: https://www.youtube.com/watch?v=VBDlOJ6G_KI

public class keyController : MonoBehaviour
{
    [SerializeField] GameObject Player;

    public bool pickedUp;
    private Vector2 velocity;
    public float smooth;
    void Start()
    {

    }

    void Update()
    {
        if(pickedUp)
        {
            Vector3 offset = new Vector3(0, 1, 0);
            transform.position = Vector2.SmoothDamp(transform.position, Player.transform.position + offset, ref velocity, smooth);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Player") && !pickedUp)
        {
            pickedUp = true;
        }
    }

}
