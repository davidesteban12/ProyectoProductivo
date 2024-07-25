using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float velocidadMovimiento = 3.0f;
    public float limiteX = 10.0f; // L�mite en el eje X

    void Update()
    {
        float movimientoHorizontal = Input.GetAxis("Mouse X") * velocidadMovimiento * Time.deltaTime;

        // Mover la c�mara hacia la derecha
        transform.Translate(Vector3.right * movimientoHorizontal);

        // Limitar la posici�n de la c�mara
        Vector3 posicionActual = transform.position;
        posicionActual.x = Mathf.Clamp(posicionActual.x, posicionActual.x, limiteX);
        transform.position = posicionActual;
    }
}
