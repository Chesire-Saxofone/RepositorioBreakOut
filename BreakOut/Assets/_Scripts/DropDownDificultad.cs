using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownDificultad : MonoBehaviour
{
    public Opciones opciones;
    public TMP_Dropdown dificultad;

    private void Start()
    {
        dificultad = GetComponent<TMP_Dropdown>();
        dificultad.onValueChanged.AddListener(delegate {
            Opciones.Dificultad nuevaDificultad =
            (Opciones.Dificultad)(dificultad.value);
            opciones.CambiarDificultad(nuevaDificultad);
        });
    }
}
