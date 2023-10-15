using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salta : MonoBehaviour
{
    public aproxima objeto;
    bool suelo;
    // Start is called before the first frame update
    void Start()
    {
        objeto.AproximaAlCilindroEvento += saltaFuncion; 
        suelo = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {

    }

    void saltaFuncion() {
        Rigidbody rb = GetComponent<Rigidbody>(); 

        Vector3 direction = new Vector3(0f,4f,0f);
        if (suelo) {
            suelo = false;
            rb.AddForce(direction, ForceMode.Impulse);
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "Untagged") {
            suelo = true;
        }
    }
}
