using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorDeVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject menuFinDelJuego;


    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);
        }
    }

    // Update is called once per frame
    public void EliminarVidas()
    {
        //var objetoAEliminar = vidas[vidas.Count - 1];
        //Destroy(objetoAEliminar);
        //vidas.RemoveAt(vidas.Count - 1);
        //if (vidas.Count <= 0)
        //{
        //    menuFinDelJuego.SetActive(true);
        //    return;
        //}
        //var bola = Instantiate(bolaPrefab) as GameObject;
        //bolaScript = bola.GetComponent<Bola>();
        //bolaScript.BolaDestruida.AddListener(this.EliminarVidas);
        //Debug.Log($"vidas restantes {vidas.Count}");
        if (vidas.Count == 0) return;  // Evita errores si la lista está vacía

        var objetoAEliminar = vidas[vidas.Count - 1];

        if (objetoAEliminar != null)
        {
            Destroy(objetoAEliminar);
            vidas.RemoveAt(vidas.Count - 1);
        }

        if (vidas.Count <= 0)
        {
            menuFinDelJuego.SetActive(true);
            return;
        }

        var bola = Instantiate(bolaPrefab);
        bolaScript = bola.GetComponent<Bola>();

        if (bolaScript != null)
            bolaScript.BolaDestruida.AddListener(this.EliminarVidas);

        Debug.Log($"vidas restantes {vidas.Count}");
    }
}
