using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int health;
    [SerializeField]
    PlayerHealthController playerHealthController;


    // Start is called before the first frame update
    void Start()
    {
        health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    void OnTriggerEnter2D()
    {
        playerHealthController.AddScore();
        health--;
    }

    void Die()
    {
        Destroy(gameObject);
    }

   

    // Update is called once per frame
   
}
