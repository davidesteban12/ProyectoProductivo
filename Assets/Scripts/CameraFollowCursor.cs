using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCursor : MonoBehaviour
{
    public float velocidadMovimiento = 10f; // Velocidad a la que se mover� la c�mara
    public float limiteIzquierdo = -10f; // L�mite izquierdo de la c�mara
    public float limiteDerecho = 10f; // L�mite derecho de la c�mara

    void Update()
    {
        // Obtener la posici�n del cursor en la pantalla
        Vector3 posicionCursor = Input.mousePosition;

        // Convertir la posici�n del cursor a coordenadas del mundo
        Vector3 posicionMundo = Camera.main.ScreenToWorldPoint(posicionCursor);

        // Obtener la posici�n actual de la c�mara
        Vector3 posicionCamara = transform.position;

        // Calcular la nueva posici�n de la c�mara basada en la posici�n horizontal del cursor
        posicionCamara.x = Mathf.Lerp(posicionCamara.x, posicionMundo.x, velocidadMovimiento * Time.deltaTime);

        // Aplicar los l�mites para que la c�mara no se salga del �rea del juego
        posicionCamara.x = Mathf.Clamp(posicionCamara.x, limiteIzquierdo, limiteDerecho);

        // Establecer la nueva posici�n de la c�mara
        transform.position = posicionCamara;
    }
}