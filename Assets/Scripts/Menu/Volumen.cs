using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    public Slider volumeSlider;  // Referencia al slider

    void Start()
    {
        // Configurar el slider con el valor guardado o con el valor por defecto
        volumeSlider.value = PlayerPrefs.GetFloat("volume", 1f);  // Volumen predeterminado es 1 (m�ximo)
        AudioListener.volume = volumeSlider.value;

        // Suscribirse al evento del slider para ajustar el volumen en tiempo real
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    // Funci�n que ajusta el volumen general del juego
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("volume", volume);  // Guardar el volumen en PlayerPrefs
    }

    void OnDisable()
    {
        // Almacenar el valor del volumen cuando se cierra la aplicaci�n o se desactiva el objeto
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}

