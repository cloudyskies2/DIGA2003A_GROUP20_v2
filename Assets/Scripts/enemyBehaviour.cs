using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 4;
    public enemyHealthBarBehaviour HealthBar;

    void Start()
    {
        Hitpoints = MaxHitPoints;
        HealthBar.SetHealth(Hitpoints, MaxHitPoints);
    }

    public void TakeDamage(float damage)
    {
        Hitpoints -= damage;

        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
