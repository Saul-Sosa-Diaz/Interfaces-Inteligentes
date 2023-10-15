using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aproxima : MonoBehaviour
{
    public delegate void AproximaAlCilindro();
    public event AproximaAlCilindro AproximaAlCilindroEvento;
    public float distancia_minima = 0.16f; // Distancia que hay que recorrer para que se considere que se ha movido
    float distanciaPrevia = 0f;

    // Start is called before the first frame update
    void Start()
    {
        distanciaPrevia = Vector3.Distance(GameObject.FindGameObjectWithTag("Cylinder").transform.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        Vector3 posicionCilindroActual = GameObject.FindGameObjectWithTag("Cylinder").transform.position;
        float distActual = Vector3.Distance(posicionCilindroActual, transform.position);
        
        if (distActual  < distanciaPrevia - distancia_minima) {  // Si se ha acercado
            if (AproximaAlCilindroEvento != null) {
                AproximaAlCilindroEvento();
            }
        }
        distanciaPrevia = distActual;
    }
}