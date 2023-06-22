using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;
    public HealthBar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;

        healthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        healthBar.SetSlider(currentHealth);
    }

    /*
    public void Heal(float amount)
    {
        currentHealth += amount;
        healthBar.SetSlider(currentHealth); 
    }
    */

    private void Update()
    {
        if (currentHealth <= 0) {
            Death();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("YouDied");
    }
}
