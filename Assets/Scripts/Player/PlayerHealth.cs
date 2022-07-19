using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerHealthBar healthBar;
    private int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetPlayerMaxhealth(maxHealth);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemybullet" || collision.gameObject.tag == "Playerbullet")
        {
            TakeDamage(1);
        }
    }

    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetPlayerHealth(currentHealth);
        if (currentHealth <= 0)
        {
            
        }
    }

}
