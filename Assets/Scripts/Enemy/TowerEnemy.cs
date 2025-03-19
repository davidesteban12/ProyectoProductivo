using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TowerEnemy : MonoBehaviour
{
    public float maxhealth = 20;
    public float currentHealth;
    public Slider slider;
    public GameObject siguiente;

    void Start()
    {
        currentHealth = maxhealth;
        slider.maxValue = maxhealth;
        siguiente.SetActive(false);
    }

    void Update()
    {
        slider.value = currentHealth;
        if (currentHealth <= 0)
        {
          siguiente.SetActive(true);
          Destroy(gameObject);
        }
    }
}




