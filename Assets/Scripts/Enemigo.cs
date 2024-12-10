using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicion;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicion = camara.ViewportToWorldPoint(new Vector2(0, 0));
    }

    private void SetActive(bool v)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidad * Time.deltaTime);
        if (transform.position.x < posicion.x)
        {
            Destroy(gameObject, 0.2f);
        }
    }
}
