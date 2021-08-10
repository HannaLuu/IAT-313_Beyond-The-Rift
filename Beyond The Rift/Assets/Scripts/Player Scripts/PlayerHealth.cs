using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("DAMAGED");

        healthBar.SetHealth(currentHealth);

        FindObjectOfType<AudioManager>().Play("BjornHit");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //well shit... bjorn dead...
        EnemyCounter.enemiesKilled = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(currentHealth);
    }
}
