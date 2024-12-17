using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limitex = 23;
    [SerializeField] public float velocidadPad = 1f;

    Vector3 jugadorPos2d;
    Vector3 jugadorPos3d;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //jugadorPos2d = Input.mousePosition;
        //jugadorPos2d.z = -Camera.main.transform.position.z;
        //jugadorPos3d = Camera.main.ScreenToWorldPoint(jugadorPos2d);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(Vector3.down * velocidadPad * Time.deltaTime);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.Translate(Vector3.up * velocidadPad * Time.deltaTime);
        //}


        transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * velocidadPad * Time.deltaTime);

        Vector3 pos = this.transform.position;

     
        //pos.x = jugadorPos3d.x;
        if (pos.x < -23)
            pos.x = -limitex;
        else if (pos.x > limitex)
            pos.x = limitex;


        this.transform.position = pos;
    }
}
