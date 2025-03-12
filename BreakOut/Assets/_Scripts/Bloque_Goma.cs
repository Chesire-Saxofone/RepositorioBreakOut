using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Goma : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 2; 
    }

    public override void RebotarBola(Collision collision)
    {
        //la bola tendrá un mayor rebote. Será un bloque de mayor
        //dificultad por lo que habrá pocos.
        //aun por implementar cuando aprenda sobre el metodo de rebote.
        base.RebotarBola(collision);
        opciones.CambiarVelocidad(opciones.velocidadBola + 10);
    }

    private void Update()
    {
        Incremento();
    }
}
