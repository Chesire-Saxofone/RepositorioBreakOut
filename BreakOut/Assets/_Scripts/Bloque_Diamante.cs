using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque_Diamante : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 6;
    }
    /* deseo crear un metodo que permita destruir los bloques
     * adjacentes con una explosión el ser destruido. sin
     * Embargo tengo la duda de si debo hacerlo en este 
     * script o en la clase padre de Bloque*/
}
