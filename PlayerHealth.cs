using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    private Vector2 initialPosition;

    void Start()
    {

        health = maxHealth;
        initialPosition = transform.position;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Respawn();

        }

        void Respawn()
        {
            health = maxHealth;
            transform.position = initialPosition;
        }

    }

   
}

