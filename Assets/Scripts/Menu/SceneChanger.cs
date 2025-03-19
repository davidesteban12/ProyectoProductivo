using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    /*  Nombres De Las Escenas
     Menu
     Nivel_01
     Nivel_02
     Nivel_03
     Nivel_04
     Slc
    */
    public void CambiarEscena(string nombre)
    {
       SceneManager.LoadScene(nombre);
    }

    // Este método se llamará al completar un nivel
    
}

