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

    void Start()
    {
        currentHealth = maxhealth;
        slider.maxValue = maxhealth;
    }

    void Update()
    {
        slider.value = currentHealth;
        if (currentHealth <= 0)
        {
                  // Cambia a la escena de selección de niveles
            SceneChanger sceneChanger = FindObjectOfType<SceneChanger>();
            if (sceneChanger != null)
            {
                sceneChanger.UnlockNextLevel(1); // Desbloquear el nivel 2 al completar el nivel 1
            }
            SceneManager.LoadScene("Slc"); // Cambiar a la selección de niveles
            Destroy(gameObject); // Destruye el objeto
        }
    }
}


