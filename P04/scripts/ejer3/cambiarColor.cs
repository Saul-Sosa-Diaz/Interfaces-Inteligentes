using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarColor : MonoBehaviour
{
    // Start is called before the first frame update
    public aproxima objeto;
    bool suelo;
    // Start is called before the first frame update
    void Start()
    {
        objeto.AproximaAlCilindroEvento += cambiarColorFuncion; 
        suelo = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {

    }

    void cambiarColorFuncion() {
        if (suelo) {
            suelo = false;
            GetComponent<Renderer>().material.color = new Color(UnityEngine.Random.Range(0.0f,0.9f),UnityEngine.Random.Range(0.0f,0.9f), UnityEngine.Random.Range(0.0f,0.9f));
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Untagged") {
            suelo = true;
        }
    }



}
