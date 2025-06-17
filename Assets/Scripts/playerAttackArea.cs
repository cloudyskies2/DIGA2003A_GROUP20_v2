using UnityEngine;
using System.Collections;

public class playerAttackArea : MonoBehaviour
{
    private int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<enemyBehaviour>() !=null)
        {
            enemyBehaviour health = collision.GetComponent<enemyBehaviour>();
            health.TakeDamage(damage);
        }
    }

}
