using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoCama : MonoBehaviour
{
    CamaPersona movimientoDerechaIzquierda;
    private Vector3 posicionInicial;

    bool movimiento;
    // Start is called before the first frame update
    void Start()
    {
        movimiento = false;
        posicionInicial = transform.position;
        movimientoDerechaIzquierda = GameObject.FindGameObjectWithTag("Player").GetComponent<CamaPersona>();
        movimientoDerechaIzquierda.CamaPersonaTocadaEvento += ActivarMovimientoFuncion;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
     if (movimiento) {
       Rigidbody rb = GetComponent<Rigidbody>();
       float nuevaz = posicionInicial.z + Mathf.Sin(Time.time * 2f) * 0.2f;
       Vector3 newpos = new Vector3(transform.position.x, transform.position.y, nuevaz);
       rb.MovePosition(newpos);
      }
    }

    void ActivarMovimientoFuncion() {
        movimiento = true;
    }

}
