using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int puntuacionActual, puntuacionMaxima;
    [SerializeField] float tiempo;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        puntuacionActual = PlayerPrefs.GetInt("mejorPuntuacion");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual++;
        if (puntuacionActual < puntuacionMaxima)
        {
            puntuacionMaxima = puntuacionActual;
        }
    }
    public void Perder()
    {

    }
}
