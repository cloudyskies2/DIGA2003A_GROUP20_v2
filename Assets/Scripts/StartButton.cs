using UnityEngine;
using UnityEngine.SceneManagement;

//Title: Make Your MAIN MENU Quickly! | Unity UI Tutorial For Beginners
//Author: Rehope Games
//Date: 15 April 2025
//Code Version: Unity 2021.3.23f1
//Availability: https://www.youtube.com/watch?v=DX7HyN7oJjE&t=355s

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
