using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

//Title: Key and Door System | Multiple keys and doors Unity Tutorial
//Author: MoreBBlakeyyy
//Date: 22 April 2025
//Code Version: Unity 2021.3.20f1
//Availability: https://www.youtube.com/watch?v=WKJy-dUK2NY

//Title: Unity Tutorial - Key door system for any 2d game
//Author: PitiIT
//Date: 22 April 2025
//Code Version: Unity 2021.3.8f1
//Availability: https://www.youtube.com/watch?v=1IJmenD1HOk

public class prisonDoorController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Sword;
    [SerializeField] GameObject prisonDoor;
    [SerializeField]
    private TMP_Text prisonDoorText;
    public bool locked;
    //public int sceneBuildIndex;

    void Start()
    {
        locked = true;
        prisonDoorText.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            prisonDoorText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            prisonDoorText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q) && Sword == null)
        {
            Destroy(prisonDoor);
            locked = false;
            prisonDoorText.gameObject.SetActive(false);
        }
    }

    /*private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }*/

 
}
