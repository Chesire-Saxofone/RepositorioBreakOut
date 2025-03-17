using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
    public Opciones opciones;

    bool isTheGameStarted = false;
    [SerializeField] public float velocidadBola = 20f;
    Vector3 ultimaPosicion  = Vector3.zero;
    Vector3 direccion = Vector3.zero;
    Rigidbody rigidbody1;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control= GetComponent<ControlBordes>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 posicionInicial = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        posicionInicial.y += 3;
        this.transform.position = posicionInicial;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody1 = this.gameObject.GetComponent<Rigidbody>();
        rigidbody1.velocity = Vector3.zero; // Asegurar que comienza en reposo

    }

    // Update is called once per frame
    void Update()
    {

        if (opciones != null)
        {
            velocidadBola = opciones.velocidadBola;  // Tomar el valor desde opciones
        }

        if (control.salioAbajo)
        {
            if (BolaDestruida != null)
                BolaDestruida.Invoke();

            Destroy(this.gameObject);
        }
        if (control.salioArriba)
        {


            direccion = transform.position - ultimaPosicion;
            Debug.Log("la bola tocó el borde superior");
            direccion.y *= -1;
            direccion = direccion.normalized;
            rigidbody1.velocity = velocidadBola * direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
        if (control.salioDerecha)
        {


            direccion = transform.position - ultimaPosicion;
            Debug.Log("la bola tocó el borde derecho");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody1.velocity = velocidadBola * direccion;
            control.salioDerecha = false;
        }
        if (control.salioIzquierda)
        {


            direccion = transform.position - ultimaPosicion;
            Debug.Log("la bola tocó el borde izquierdo");
            direccion.x *= -1;
            direccion = direccion.normalized;
            rigidbody1.velocity = velocidadBola * direccion;
            control.salioIzquierda = false;
        }
        if (Input.GetKeyUp(KeyCode.Space)|| Input.GetButton("Submit"))
        {
            if (!isTheGameStarted)
            { 
            isTheGameStarted=true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
            }
        }
    }

    private void Rebote(Vector3 nuevaDireccion)
    {
        nuevaDireccion = nuevaDireccion.normalized;
        rigidbody1.velocity = nuevaDireccion * velocidadBola;
    }

    private void HabilitarControl()
    {
        control.enabled = true;
    }

    private void LateUpdate()
    {
        if (direccion != Vector3.zero) direccion = Vector3.zero;
    }
    private void FixedUpdate()
    {
        ultimaPosicion = transform.position;
    }
}
