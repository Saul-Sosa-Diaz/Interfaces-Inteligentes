using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion : MonoBehaviour
{
    int puntuacionActual;
    movimiento salto;
    void Start()
    {
        puntuacionActual = 0;
        salto = GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento>();
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col) {
        salto = GameObject.FindGameObjectWithTag("Player").GetComponent<movimiento>();
        if (col.gameObject.tag == "araña" && salto.suelo != false) {
            SubirPuntuacionActual(col.gameObject.tag);
            DestruirObjeto(col.gameObject);
        }
    }

    void SubirPuntuacionActual(string tag) {

        puntuacionActual += 10;

        Debug.Log(puntuacionActual);
        
    }

    void DestruirObjeto(GameObject objeto) {
        Destroy(objeto);
    }
}
