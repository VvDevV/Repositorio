using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearElementos : MonoBehaviour
{
    [SerializeField] GameObject enemigo1, enemigo2;
    [SerializeField] Camera camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        StartCoroutine(CrearEnemigo1());
        StartCoroutine(CrearEnemigo2());
    }

    IEnumerator CrearEnemigo1()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            GameObject enemigo = Instantiate<GameObject>(enemigo1);
            enemigo.transform.position = new Vector2(11.95571f, -0.18f);
        }
    }

    IEnumerator CrearEnemigo2()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3f, 10f));
            GameObject enemigo = Instantiate<GameObject>(enemigo2);
            enemigo.transform.position = new Vector2(12.58947f, 2.92f);
        }
    }
}
