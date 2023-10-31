using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaPersona : MonoBehaviour
{   
    public delegate void CamaPersonaTocada();
    public event CamaPersonaTocada CamaPersonaTocadaEvento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "camaPersona") {
          CamaPersonaTocadaEvento();
        } 
    }
}
