using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_maneger : MonoBehaviour
{
    public static game_maneger instance;
    public Button[] botoneNiveles;
    public int desbloquearNiveles;

    // Bool para resetear desde el Inspector
    [Header("Resetear progreso desde el Inspector")]
    public bool resetearProgreso = false;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        if (botoneNiveles.Length > 0)
        {
            for (int i = 0; i < botoneNiveles.Length; i++)
            {
                botoneNiveles[i].interactable = false;
            }
            for (int i = 0; i < PlayerPrefs.GetInt("nivelesDesbloqueados", 1); i++)
            {
                botoneNiveles[i].interactable = true;
            }
        }
    }

    public void AumentarNiveles()
    {
        int nivelesDesbloqueados = PlayerPrefs.GetInt("nivelesDesbloqueados", 1);

        if (desbloquearNiveles > nivelesDesbloqueados)
        {
            PlayerPrefs.SetInt("nivelesDesbloqueados", desbloquearNiveles);
        }
    }

    // Método para resetear los niveles desbloqueados
    public void ResetNivelesDesbloqueados()
    {
        PlayerPrefs.DeleteKey("nivelesDesbloqueados");
        Debug.Log("Progreso de niveles reseteado.");
        SceneManager.LoadScene("Menu");  // Recargar el menú después de resetear
    }

    // Método para resetear todo el progreso
    public void ResetearTodoProgreso()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Todas las preferencias han sido reseteadas.");
        SceneManager.LoadScene("Menu");  // Recargar el menú después de resetear
    }

    // Verifica si resetearProgreso es verdadero en cada frame
    void Update()
    {
        if (resetearProgreso)
        {
            // Llama al método para resetear los niveles
            ResetNivelesDesbloqueados();
            // Desactiva el bool para evitar que se repita en el siguiente frame
            resetearProgreso = false;
        }
    }
}

