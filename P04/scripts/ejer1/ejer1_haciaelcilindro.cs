using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1_haciaelcilindro : MonoBehaviour
{
    public ejer1_notificador notificador;
    // Start is called before the first frame update
    void Start()
    {
      notificador.OnMiEvento += ToTheCylinder;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void ToTheCylinder() {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 direction = Vector3.Normalize(GameObject.FindWithTag("Cylynder").transform.position - transform.position);
        rb.AddForce(direction * 100);
    }
}
