using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class movimientoAranaA : MonoBehaviour
{
    Vector3 posSilla;
    Vector3 posMesa;
    bool movimi;
    // Start is called before the first frame update
    void Start()
    {
        movimi = false;
        posSilla = GameObject.FindGameObjectWithTag("silla").GetComponent<Transform>().position;
        posMesa = GameObject.FindGameObjectWithTag("mesa").GetComponent<Transform>().position;
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
    
    void FixedUpdate() {
        Vector3 objetivo;
        if (movimi) {
            objetivo = posSilla;
        } else {
            objetivo = posMesa;
        }
        Vector3 DirectionObjetivo = objetivo - transform.position; // Target position - current position
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.Normalize(DirectionObjetivo) * 20f);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "silla") {
           movimi = false;
        } else if (col.gameObject.tag == "mesa")
        {
          movimi = true;
        }
    }
}
