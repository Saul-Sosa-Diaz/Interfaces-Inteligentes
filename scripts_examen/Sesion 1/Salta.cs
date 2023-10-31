using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salta : MonoBehaviour
{
    CamaPersona saltaEvento;
    bool suelo;
    // Start is called before the first frame update
    void Start()
    {
        suelo = true;
        saltaEvento = GameObject.FindGameObjectWithTag("Player").GetComponent<CamaPersona>();
        saltaEvento.CamaPersonaTocadaEvento += saltaFuncion;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {

    }

    void saltaFuncion() {
        Rigidbody rb = GetComponent<Rigidbody>(); 
        Vector3 direction = new Vector3(0f,1f,0f);
        if (suelo) {
            suelo = false;
            rb.AddForce(direction, ForceMode.Impulse); 
        }
    }

     void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "suelo") {
          suelo = true;
        }
    }

}
