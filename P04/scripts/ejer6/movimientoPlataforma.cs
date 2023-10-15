using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlataforma : MonoBehaviour
{
    private Vector3 posicionInicial;
    float desfase;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
        desfase = Random.Range(0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() {
       Rigidbody rb = GetComponent<Rigidbody>();
       float nuevaX = posicionInicial.x + Mathf.Sin((Time.time + desfase) * 3f) * 1f;
       Vector3 newpos = new Vector3(nuevaX, transform.position.y,transform.position.z);
       rb.MovePosition(newpos);
    }
}
