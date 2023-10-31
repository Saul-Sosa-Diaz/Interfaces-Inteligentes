using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movimientoAranab : MonoBehaviour
{
    Vector3 posA;
    Vector3 posB;
    bool movimi;
    // Start is called before the first frame update
    void Start()
    {
        movimi = false;
        posA = new Vector3(UnityEngine.Random.Range(-1.13f, 3.52f),0,UnityEngine.Random.Range(-0.36f, 9.47f));
        posB = new Vector3(UnityEngine.Random.Range(-1.13f, 3.52f),0,UnityEngine.Random.Range(-0.36f, 9.47f));
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
    
    void FixedUpdate() {
        Vector3 objetivo;
        if (movimi) {
            movimi = false;
            objetivo = posA;
        } else {
            movimi = true;
            objetivo = posB;
        }
        Vector3 DirectionObjetivo = objetivo - transform.position; // Target position - current position
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.Normalize(DirectionObjetivo) * 60f);
    }

}
