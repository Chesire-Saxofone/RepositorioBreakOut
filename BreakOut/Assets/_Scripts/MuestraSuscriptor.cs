using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraSuscriptor : MonoBehaviour
{
    MuestraEventos suscriptor;
    // Start is called before the first frame update
    void Start()
    {
        suscriptor = GetComponent<MuestraEventos>();
        suscriptor.onScpace += MensajeEscuchadoPorSuscriptor;
    }

   private void MensajeEscuchadoPorSuscriptor(object sender, EventArgs e)
    {
        Debug.Log("el evento se ha escuchado desde otra clase");
        suscriptor.onScpace -= MensajeEscuchadoPorSuscriptor;
    } 
}
