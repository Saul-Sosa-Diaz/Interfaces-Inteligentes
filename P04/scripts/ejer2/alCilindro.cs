using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alCilindro : MonoBehaviour
{   
    public choca ChocaConAlgo;
    // Start is called before the first frame update
    void Start()
    {
      ChocaConAlgo.ChocaConCualquieraNoTipo1 += MoverAlCilindro;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void MoverAlCilindro() {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 direction = Vector3.Normalize(GameObject.FindWithTag("Cylinder").transform.position - transform.position);
        rb.AddForce(direction * 100);
    }
}
