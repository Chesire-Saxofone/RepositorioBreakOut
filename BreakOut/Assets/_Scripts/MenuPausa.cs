using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menuPausa;
    public GameObject menuOpciones;

    public void MostrarMenuPausa() 
    { 
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

    public void OcultarmenuPausa()
    {
        menuPausa.SetActive(false);
    }

    public void RegresarPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }
}
