using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Llama a esta función para cambiar a la escena llamada "perdio"
    public void ChangeToPerdioScene()
    {
        SceneManager.LoadScene("perdio");
    }
    public void ChageToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
