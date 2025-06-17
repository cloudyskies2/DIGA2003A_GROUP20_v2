using JetBrains.Annotations;
using UnityEngine;

//Reference 
//https://youtu.be/tBj-FWcIwYw?si=735sqa47eYTRnVa6

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 10;
   
    public SpriteRenderer playerSr;
    public playerController1 playerMovement;

    public GameManagerScrpt gameManager;
    private bool isDead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount; 
        if(health <= 0 && !isDead)
        {
            isDead = true;
            gameManager.gameOver();

            playerSr.enabled = false;
            playerMovement.enabled = false;
        }
    }
}
