using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloques : MonoBehaviour
{
    public GameObject MenuFinNivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            MenuFinNivel.SetActive(true);
        }
    }
}
