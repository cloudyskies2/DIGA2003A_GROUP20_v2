using UnityEngine;
using System.Collections;

public class playerAttackArea : MonoBehaviour
{
    private int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerHealth>() !=null)
        {
            PlayerHealth health = collision.GetComponent<PlayerHealth>();
            health.TakeDamage(damage);
        }
    }

}
