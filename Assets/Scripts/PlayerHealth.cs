using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IHealth
{
    public int MaxHealth { get; set; }
    public int CurrentHealth { get; set; }

    private void start()
    {
        MaxHealth = 2;
        CurrentHealth = MaxHealth;
    }
    public void TakeDamage(int damageAmount)
    {
        CurrentHealth -= damageAmount;
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    public void Heal(int healAmount)
    {
        CurrentHealth += healAmount;
        if (CurrentHealth > MaxHealth)
        {
            CurrentHealth = MaxHealth;
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }


}
