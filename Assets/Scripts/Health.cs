using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health { get; private set; }
    [SerializeField] private int maxHealth;

    private void Start()
    {
        maxHealth = 10;
        health = maxHealth;
    }

    public void DealDamage(int dmg)
    {
        health -= dmg;
    }

    public void Heal(int dmg)
    {
        health += dmg;
    }
}
