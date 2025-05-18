using UnityEngine;
using System.Collections;

//Title: Unity simple 2D Enemy AI Follow Tutorial
//Author: MoreBBlakeyyy
//Date: 16 April 2025
//Code Version: Unity 2020.3.20f1
//Availability: https://www.youtube.com/watch?v=2SXa10ILJms

public class EnemyMovement : MonoBehaviour
{
    public GameObject Player;
    public float speed;

    private float distance;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position);
        Vector2 direction = Player.transform.position - transform.position;

        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 

        if(distance < 4)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
           

            animator.SetFloat("MoveX", direction.x);
            animator.SetFloat("MoveY", direction.y);
        }
        else
        {
            animator.SetFloat("MoveX", 0);
            animator.SetFloat("MoveY", 0);
        }
    }
}
