using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoMoneda : MonoBehaviour
{
    private Vector3 posicionInicial;
    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate() {
       Rigidbody rb = GetComponent<Rigidbody>();
       float nuevaY = posicionInicial.y + Mathf.Sin(Time.time * 1f) * 0.25f;
       Vector3 newpos = new Vector3(transform.position.x, nuevaY,transform.position.z);
       rb.MovePosition(newpos);

       Vector3 rotation = new Vector3(70f* Time.fixedDeltaTime, 0f, 0f); // Al ser un cilindro lo que hay que rotar es el eje x porque está de lado
       Quaternion deltaRotation = Quaternion.Euler(rotation);
       rb.MoveRotation(rb.rotation * deltaRotation);
    }
}
