using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    //Title: How to Switch Levels with Trigger Area for 2D RPGs in Unity
    //Author: Chris' Tutorials
    //Date: 15 April 2025
    //Code Version: N/A (Untiy 2020 version)
    //Availability: https://www.youtube.com/watch?v=-7I0slJyi8g&t=1s

    public int sceneBuildIndex;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
    /*private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }*/
}
