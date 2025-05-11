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

public class doorController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    public bool locked;
    public int sceneBuildIndex;

    void Start()
    {
        locked = true;
    }

    void Update()
    {
        if(!locked)
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }

    /*private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            locked = false;
        }
    }
}
