using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] public float velocidad;
    [SerializeField] public bool EnSuelo;
    [SerializeField] public Animator animator;

    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime * Input.GetAxis("Jump"));
        if (Input.GetKey(KeyCode.Space) && EnSuelo == true)
        {
            animator.SetBool("Salta", true);
            velocidad = 13;
            EsperarParaPulsar();
        }
        else
        {
            animator.SetBool("Salta", false);
            velocidad = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Suelo")
        {
            EnSuelo = true;
        }
        else 
        {
            EnSuelo = false;
        }
    }
    IEnumerator EsperarParaPulsar()
    {
        yield return new WaitForSeconds(1);
    }
}