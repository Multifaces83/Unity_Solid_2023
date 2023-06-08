using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyFood : MonoBehaviour, ICollectable, ILifeModifier
{
    [SerializeField] private int healAmount = 1;
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
        playerHealth.Heal(healAmount);
    }

}
