using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private Seguros seguros;

    void Start()
    {
        // Encuentra el script Seguros en la escena
        seguros = FindObjectOfType<Seguros>();
    }

    public void UnlockNextLevel(int completedLevel)
    {
        if (seguros != null)
        {
            seguros.UnlockNextLevel(completedLevel); // Desbloquea el nivel en Seguros
        }
    }

    public void ChangeToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Nivel1()
    {
        if (seguros.IsLevelUnlocked(1)) // Verifica si el nivel 1 está desbloqueado
        {
            SceneManager.LoadScene("Nivel_01");
        }
        else
        {
            Debug.Log("Nivel 1 está bloqueado."); // Mensaje de depuración
        }
    }

    public void Nivel2()
    {
        if (seguros.IsLevelUnlocked(2)) // Verifica si el nivel 2 está desbloqueado
        {
            SceneManager.LoadScene("Nivel_02");
        }
        else
        {
            Debug.Log("Nivel 2 está bloqueado."); // Mensaje de depuración
        }
    }

    public void Nivel3()
    {
        if (seguros.IsLevelUnlocked(3)) // Verifica si el nivel 3 está desbloqueado
        {
            SceneManager.LoadScene("Nivel_03");
        }
        else
        {
            Debug.Log("Nivel 3 está bloqueado."); // Mensaje de depuración
        }
    }

    public void Nivel4()
    {
        if (seguros.IsLevelUnlocked(4)) // Verifica si el nivel 4 está desbloqueado
        {
            SceneManager.LoadScene("Nivel_04");
        }
        else
        {
            Debug.Log("Nivel 4 está bloqueado."); // Mensaje de depuración
        }
    }
}



