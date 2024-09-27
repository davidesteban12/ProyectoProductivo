using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaH : MonoBehaviour
{
    public float health;
    public float maxHealth = 30;
    public TowerEnemy towerenemy;
    public TowerHealth towerhealth;

    void Start()
    {
        towerenemy = FindObjectOfType<TowerEnemy>();
        towerhealth = FindObjectOfType<TowerHealth>();
        health = maxHealth;
    }

    void Update()
    {
        if (health <= 0)
        {
            StartCoroutine(WaitForDead());
        }
        if (towerenemy.currentHealth <= 0 || towerhealth.currentHealth <= 0)
        {
           Destroy(gameObject);
        }
    }

    IEnumerator WaitForDead()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
