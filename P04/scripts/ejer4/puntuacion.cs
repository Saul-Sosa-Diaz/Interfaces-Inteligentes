using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion : MonoBehaviour
{
    public int puntuacionActual;
    public delegate void SubirPuntuacion();
    public event SubirPuntuacion SubirPuntuacionEvento;
    // Start is called before the first frame update
    void Start()
    {
        puntuacionActual = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "sphere_type_1" || col.gameObject.tag == "sphere_type_2" ) {
            SubirPuntuacionActual(col.gameObject.tag);
            DestruirObjeto(col.gameObject);
            SubirPuntuacionEvento();
        }
         

    }

    void SubirPuntuacionActual(string tag) {
        if (tag == "sphere_type_1") {
            puntuacionActual += 5;
        } else {
            puntuacionActual += 10;
        }
        Debug.Log(puntuacionActual);
        
    }

    void DestruirObjeto(GameObject objeto) {
        Destroy(objeto);
    }
}
