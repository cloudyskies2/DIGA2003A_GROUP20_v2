using Unity.VisualScripting;
using UnityEngine;

//Title: Enemy Patrolling Unity Tutorial
//Author: MoreBBlakeyyy
//Date: 17 April 2025
//Code Version: Unity 2020.3.25f1
//Availability: https://www.youtube.com/watch?v=4mzbDk4Wsmk

public class GuardMovement : MonoBehaviour
{
    public float speed;
    public int point;
    public Transform[] patrolPoint;


    void Start()
    {
        point = 0;
    }


    void Update()
    {
        if(transform.position == patrolPoint[point].position)
        {
            changePointInt();
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoint[point].position, speed * Time.deltaTime);
    }

    void changePointInt()
    {
        point++;
        if(point >= patrolPoint.Length)
        {
            point = 0;
        }
    }

}
