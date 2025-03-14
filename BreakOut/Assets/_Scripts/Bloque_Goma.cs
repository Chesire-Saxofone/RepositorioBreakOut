using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Goma : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2; 
        Incremento();
    }

    public override void RebotarBola(Collision collision)
    {
        //la bola tendrá un mayor rebote. Será un bloque de mayor
        //dificultad por lo que habrá pocos.
        //aun por implementar cuando aprenda sobre el metodo de rebote.
        base.RebotarBola(collision);
        if (goma == false)
        {
            Debug.Log("Estamos en true");
            goma = true;
        }
    }

    private void Update()
    {
        
    }
}
