using TMPro;
using UnityEngine;

public class playerController1 : MonoBehaviour
{
    //Title: Week 6 - Conditional Statements, Switch Statements & Player Input
    //Author: Andrea Hayes
    //Date: 04 April 2025
    //Code Version: Unity 6000.0.40f1
    //Availability: https://ulwazi.wits.ac.za/courses/81381/files/8533066?module_item_id=904957

    public int moveSpeed = 4;
    public GameObject Player1;

    private int keyCount = 0;
    public TMP_Text keyTextCount;

    //public GameObject attackStrike;
    //public float radius;
<<<<<<< Updated upstream
    //public LayerMask enemy;
    //public GameObject EnemyHealth;
=======
    public LayerMask enemy;
    //public GameObject EnemyHealth;

    //public enemyHealthController someclass;

>>>>>>> Stashed changes

<<<<<<< Updated upstream
=======
    //public enemyHealthController someclass;


>>>>>>> Stashed changes
    void Start()
    {
        Player1 = this.gameObject;

    }

    void MovePlayer()
    {
        Vector3 movePosition = Vector3.zero; //(0 ; 0 ; 0)

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movePosition.y += 1; //(0 ; 1 ; 0)
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movePosition.y -= 1; //(0 ; -1 ; 0)
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movePosition.x -= 1; //(-1 ; 0 ; 0)
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movePosition.x += 1; //(+1 ; 0 ; 0)
        }

        Player1.transform.position += movePosition.normalized  * moveSpeed * Time.deltaTime;
<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
=======
>>>>>>> Stashed changes

        //Debug.DrawRay(gameObject.transform.position, Vector2.up * 2, Color.red);
        //RaycastHit2D enemyInfo = Physics2D.Raycast(gameObject.transform.position, Vector2.up, 2f, enemy);

        /*if (Input.GetKey(KeyCode.Q) && enemyInfo.collider == true)
        {
            
        }*/
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
    }

    void Update()
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
        MovePlayer(); //A function
=======
        MovePlayer(); //A function      
>>>>>>> Stashed changes
=======
        MovePlayer(); //A function      
>>>>>>> Stashed changes
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Key")
        {
            keyCount += 1;
            keyTextCount.text = "Keys " + keyCount + "/2";
        }
    }

  

    //Title: 2D Melee Combat Unity Tutorial
    //Author: MoreBBlakeyyy
    //Date: 21 April 2025
    //Code Version: 2020.3.25f1 (Unity version)
    //Availability:https://www.youtube.com/watch?v=rwO3TE1G3ag&t=521s

    /*public void attack()
    {
        Collider2D[] enemy = Physics2D.OverlapCircleAll(attackStrike.transform.position, radius, enemies);

        foreach (Collider2D enemyGameObject in enemy)
        {

        }
<<<<<<< Updated upstream
<<<<<<< Updated upstream
    }
=======
    }*/
>>>>>>> Stashed changes
=======
    }*/
>>>>>>> Stashed changes
}
