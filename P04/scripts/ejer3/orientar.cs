using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientar : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject cubo;
    aproxima objeto;
    GameObject[] spheres;
    public GameObject Objetivo;
    float aumento = 2;

    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindGameObjectWithTag("Cube");
        spheres = GameObject.FindGameObjectsWithTag("sphere_type_2");
        objeto = cubo.GetComponent<aproxima>();
        objeto.AproximaAlCilindroEvento += alinear;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {

    }
    
    void alinear() {
        float distancia = Vector3.Distance(cubo.transform.position, Objetivo.transform.position);
        Vector3 direccion = Vector3.Normalize(Objetivo.transform.position - cubo.transform.position);
        aumento = distancia / (spheres.Length - 1); // Resta 1 para evitar superponer la última esfera con el objetivo.
        Vector3 posicion;
        for (int i = 0; i < spheres.Length; i++) {
            Rigidbody rb = spheres[i].GetComponent<Rigidbody>();
            if (i == 0) {
                posicion = cubo.transform.position + direccion * (aumento/2);
                rb.MovePosition(posicion);
                continue;
            }
            posicion = cubo.transform.position + direccion * (i * aumento);
            rb.MovePosition(posicion);
        }
    }

}
