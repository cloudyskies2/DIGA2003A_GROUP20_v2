using UnityEngine;
using System.Collections;


//Title: Unity 2D Smooth Camera Follow Tutorial
//Author: MoreBBlakeyyy
//Date: 15 April 2025
//Code Version: Unity 2020.3.20f1
//Availability: https://www.youtube.com/watch?v=TYefpMf0cJ8

public class CameraMovement : MonoBehaviour
{

    public Transform Player;
    public float speed;
    public Vector3 offset;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 goodPosition = Player.position + offset;
        transform.position = Vector3.Lerp(transform.position, goodPosition, speed * Time.deltaTime);
    }
}
