using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{

    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("Record").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("Puntaje Alto"))
        //{
        //    puntajeAltoSO.puntajeAlto = PlayerPrefs.GetInt("Puntaje Alto");
        //}
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"PuntajeAlto {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;
    }


    private void FixedUpdate()
    {
        puntajeAltoSO.puntaje += 50;
    }
    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"Puntaje Actual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje ;
            textoPuntajeAlto.text = $"Record: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("puntajeAlto", puntajeAltoSO.puntaje);
        }
    }
}
