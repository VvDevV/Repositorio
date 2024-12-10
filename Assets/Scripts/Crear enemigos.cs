using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    [SerializeField] GameObject vida, enemigo;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionMaxima;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionMaxima = camara.ViewportToWorldPoint(new Vector2(1, 1));
        StartCoroutine(CrearVida());
        StartCoroutine(CrearEnemigo());
    }

    IEnumerator CrearVida()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            GameObject vidanueva = Instantiate<GameObject>(vida);
            vidanueva.transform.position = CalcularPosicionAleatoria();
        }
    }
    IEnumerator CrearEnemigo()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(-10f, -50f));
            GameObject vidanueva = Instantiate<GameObject>(enemigo);
            vidanueva.transform.position = CalcularPosicionAleatoria();
        }
    }

    Vector2 CalcularPosicionAleatoria()
    {
        Vector2 posicion = new Vector2();
        posicion.x = posicionMaxima.x + 1;
        float alto = posicionMaxima.y - posicionMinima.y;
        posicion.y = posicionMinima.y + alto * Random.Range(0.2f, 0.8f);
        return posicion;
    }
}