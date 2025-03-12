using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static Opciones;

public class Bloque : MonoBehaviour
{
    public Opciones opciones;

    public int resistencia = 1;
    public UnityEvent AumentarPuntaje;
    public bool goma = false;

    public virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
           
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
        if (goma == true)
        {
            Debug.Log("Estamos en false");
            opciones.velocidadBola -= 10f;
            goma = false;
        }
    }

   

    public virtual void Incremento()
    {
        switch (opciones.NivelDificultad)
        {
            case Dificultad.facil:
                resistencia += 0; // Si la dificultad es fácil, aumentamos la resistencia ligeramente
                break;

            case Dificultad.normal:
                resistencia += 1; // En dificultad media, aumentamos la resistencia más
                break;

            case Dificultad.dificil:
                resistencia += 2; // En dificultad difícil, aumentamos la resistencia aún más
                break;

            default:
                resistencia += 0; // Por si acaso, aunque esto no debería ocurrir
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        opciones.CambiarDificultad(Opciones.Dificultad.facil);
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            Destroy(this.gameObject);
            AumentarPuntaje.Invoke();
        }

        Incremento();
    }

    public virtual void RebotarBola()
    {

    }
}
