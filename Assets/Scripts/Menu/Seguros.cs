using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seguros : MonoBehaviour
{
    public GameObject[] levelLocks; // Imágenes que bloquean los niveles
    private int highestLevelUnlocked;
    public bool reiniciar = false;

    void Start()
    {
        // Carga el nivel más alto desbloqueado (por defecto, solo el primer nivel desbloqueado)
        highestLevelUnlocked = PlayerPrefs.GetInt("HighestLevelUnlocked", 1);

        // Desbloquea los niveles según el progreso guardado
        for (int i = 0; i < levelLocks.Length; i++)
        {
            if (i + 1 <= highestLevelUnlocked)
            {
                levelLocks[i].SetActive(false); // Desbloquear el nivel
            }
            else
            {
                levelLocks[i].SetActive(true); // Bloquear el nivel
            }
        }

        if (reiniciar)
        {
            ResetProgress();
        }
    }

    // Desbloquea el siguiente nivel cuando el jugador completa uno
    public void UnlockNextLevel(int completedLevel)
    {
        if (completedLevel >= highestLevelUnlocked)
        {
            highestLevelUnlocked = completedLevel + 1;
            PlayerPrefs.SetInt("HighestLevelUnlocked", highestLevelUnlocked); // Guardar el progreso
            PlayerPrefs.Save();
        }
    }

    // Verifica si un nivel está desbloqueado
    public bool IsLevelUnlocked(int level)
    {
        return level <= highestLevelUnlocked;
    }

    // Reinicia el progreso (por ejemplo, al comenzar una nueva partida)
    public void ResetProgress()
    {
        PlayerPrefs.DeleteKey("HighestLevelUnlocked");
        PlayerPrefs.Save();
    }


}
