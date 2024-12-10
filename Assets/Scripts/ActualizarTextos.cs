using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActualizarTextos : MonoBehaviour
{
    [SerializeField] public TMP_Text mejorPuntuacion, puntuacionActual;

    // Start is called before the first frame update
    void Start()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        /*mejorPuntuacion.text = GameManager.Instancia.mejorPuntuacion.ToString();*/

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
