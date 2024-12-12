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
            GameObject enemigo = Instantiate<GameObject>(enemigo1);
            enemigo.transform.position = new Vector2(11.95571f, -0.18f);

            int x;
            x = Random.Range(1, 3);

            if (x == 2)
            {
                yield return new WaitForSeconds(2);
            }
            else if (x == 4)
            {
                yield return new WaitForSeconds(4);
            }
        }
    }

    IEnumerator CrearEnemigo2()
    {
        //yield return new WaitForSeconds(10);

        while (true)
        {
            GameObject enemigo = Instantiate<GameObject>(enemigo2);
            enemigo.transform.position = new Vector2(12.58947f, 2.92f);

            int x;
            x = Random.Range(4, 6);

            if (x == 4)
            {
                yield return new WaitForSeconds(4);
            }
            else if(x == 6)
            {
                yield return new WaitForSeconds(6);
            }
        }
    }

}
