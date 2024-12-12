using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizarTextos : MonoBehaviour
{
    [SerializeField] public TMP_Text mejorPuntuacion, puntuacionActual;

    void Start()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacion.text = GameManager.Instancia.puntuacionMaxima.ToString();
    }
}
