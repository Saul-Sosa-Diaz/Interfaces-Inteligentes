using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aranaSalto : MonoBehaviour
{
    public bool suelo;


    
    // Start is called before the first frame update
    void Start()
    {
        suelo = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
    Rigidbody rb = GetComponent<Rigidbody>();
     if (suelo == true) { // Comprobar si esta en el aire
         suelo = false;
        Vector3 saltoFuerza = new Vector3(0f,200,0f);
        rb.AddForce(saltoFuerza);
        }
    }

    void OnCollisionEnter(Collision col) {
        suelo = true;
    }
}
