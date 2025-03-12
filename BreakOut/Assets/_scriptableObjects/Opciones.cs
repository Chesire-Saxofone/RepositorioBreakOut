using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="opciones", menuName ="Herramientas/Opciones",order = 1)]
public class Opciones : PuntajePersistente 
{
    public float velocidadBola = 30;
    public Dificultad NivelDificultad = Dificultad.facil;

    public enum Dificultad
    {
        facil,
        normal,
        dificil
    }     

 public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola = nuevaVelocidad;
    }
    
    public void CambiarDificultad(Dificultad nuevaDificultad)
    {
        NivelDificultad = nuevaDificultad;
    }
}
