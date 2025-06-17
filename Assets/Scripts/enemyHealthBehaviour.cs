using UnityEngine;

public class enemyHealthBehaviour : MonoBehaviour
{
    public float hitPoints;
    public float maxHitPoints = 5;
    public healthBarBehaviour healthBar;

    void Start()
    {
        hitPoints = maxHitPoints;
        healthBar.SetHealth(hitPoints, maxHitPoints);
    }

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;

        if(hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
