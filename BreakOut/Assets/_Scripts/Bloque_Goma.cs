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

    public override void RebotarBola()
    {
        //la bola tendr� un mayor rebote. Ser� un bloque de mayor
        //dificultad por lo que habr� pocos.
        //aun por implementar cuando aprenda sobre el metodo de rebote.
        base.RebotarBola();
    }

}
