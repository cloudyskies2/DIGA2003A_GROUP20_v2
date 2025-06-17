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
    public float radius;
    public LayerMask enemies;

    private Animator animator;
    private bool playingRunconcrete = false; // To check if the player is running on concrete or not
    public float footstepSpeed = 0.5f;

    //public ParticleSystem dustEffect;

    void Start()
    {
        Player1 = this.gameObject;
        animator = GetComponent<Animator>(); //Get the animator component attached to the player

 
    }

    void MovePlayer()
    {
        Vector3 movePosition = Vector3.zero; //(0 ; 0 ; 0)

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            movePosition.y += 1; //(0 ; 1 ; 0)
            //dustEffect.Play();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            movePosition.y -= 1; //(0 ; -1 ; 0)
            //dustEffect.Play();
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            movePosition.x -= 1; //(-1 ; 0 ; 0)
            //dustEffect.Play();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            movePosition.x += 1; //(+1 ; 0 ; 0)
            //dustEffect.Play();
        }
        Player1.transform.position += movePosition.normalized  * moveSpeed * Time.deltaTime;

        animator.SetFloat("MoveX", movePosition.x); //Set the x value of the animator
        animator.SetFloat("MoveY", movePosition.y); //Set the y value of the animator


        //Title: Add Sound Effects to Your Game! - Top Down Unity 2D #18
        //Author: Game Code Library
        //Date: 14 June 2025
        //Code Version: Unity 6000.0.40f1
        //Availability: https://www.youtube.com/watch?v=RgUA6hGnrF8&t=147s

        bool isMoving = movePosition != Vector3.zero;

        if (isMoving && !playingRunconcrete)
        {
            StartRunconcrete();
        }
        else if (!isMoving && playingRunconcrete)
        {
            StopRunconcrete();
        }
    }

    void Update()
    {
        MovePlayer(); //A function
        
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
    }*/


    //Title: Add Sound Effects to Your Game! - Top Down Unity 2D #18
    //Author: Game Code Library
    //Date: 14 June 2025
    //Code Version: Unity 6000.0.40f1
    //Availability: https://www.youtube.com/watch?v=RgUA6hGnrF8&t=147s

    void StartRunconcrete()
    {
        playingRunconcrete = true;
        InvokeRepeating(nameof(PlayRunconcrete), 0f, footstepSpeed);
    }

    void StopRunconcrete()
    {
        playingRunconcrete = false;
        CancelInvoke(nameof(PlayRunconcrete));
    }

    void PlayRunconcrete()
    {
        SoundEffectManager.Play("runconcrete");
    }

}
