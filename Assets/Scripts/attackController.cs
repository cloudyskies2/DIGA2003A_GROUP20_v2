using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class attackController : MonoBehaviour
{

    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;

    public enemyBehaviour TakeDamage;


    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyUp(KeyCode.Q))
        {
            TakeDamage.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyUp(KeyCode.Q))
        {
            TakeDamage.enabled = false;
        }
    }

    void Update()
    {
 
    }
}
