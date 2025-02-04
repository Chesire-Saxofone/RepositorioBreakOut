using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MieventoUnity;
    public event EventHandler onScpace;  
    // Start is called before the first frame update
    void Start()
    {
        onScpace += EventoDisparado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onScpace?.Invoke(this, EventArgs.Empty);
            MieventoUnity.Invoke();
        }
        
    }

    public void EventoDisparado (object sender, EventArgs e)
    {
        Debug.Log("El evento se escuchó correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("el evento unty fue escuchado");
    }
}
