using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnhealthyFood : MonoBehaviour, ICollectable, ILifeModifier
{
    private PlayerHealth playerHealth;
    [SerializeField] private int damageAmount = 1;
    public void Collect()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collect();
    }
    public void ApplyLifeModification(PlayerHealth playerHealth)
    {
        playerHealth.TakeDamage(damageAmount);
    }
}