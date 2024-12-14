using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Bambu : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        //Es un Bloque Mas largo y con mas resistencia que la madera
        resistencia = 4;
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
