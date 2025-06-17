using UnityEngine;

public class enemyHealthController : MonoBehaviour
{
    public float hitPoints;
    public float maxHitPoints = 4;
    public healthBarBehaviour healthBar;

    void Start()
    {
        hitPoints = maxHitPoints;
        healthBar.setHealth(hitPoints, maxHitPoints);
    }

    public void Impact(float damage)
    {
        hitPoints -= damage;
        healthBar.setHealth(hitPoints, maxHitPoints);

        if(hitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
