using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoEjer6 : MonoBehaviour
{
    public float speed = 10.0f;
    bool suelo;
    bool muerto;
    muerte muerteEvento;

    
    // Start is called before the first frame update
    void Start()
    {
        suelo = true;
        muerto = false;
        muerteEvento = GetComponent<muerte>();
        muerteEvento.muertoEvent += Morir;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate(){
        if (muerto == false) {
            Rigidbody rb = GetComponent<Rigidbody>();
            
            rb.MoveRotation(Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0)); // Asegurar que siempre mira arriba
            Vector3 forward = transform.forward; // No es necesario usar TransformDirection aquí
            if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f) { // Para que no patine demasiado
                Vector3 rotation = new Vector3(0f, Input.GetAxis("Horizontal") * 150f, 0f);
                Quaternion deltaRotation = Quaternion.Euler(rotation * Time.fixedDeltaTime); // Rotar
                rb.MoveRotation(rb.rotation * deltaRotation);
            }

            if (suelo == true && Input.GetAxis("Jump") != 0) { // Comprobar si esta en el aire
                suelo = false;
                Vector3 saltoFuerza = new Vector3(0f,Input.GetAxis("Jump")*200,0f);
                rb.AddForce(saltoFuerza);
            }

            Debug.DrawLine(transform.position, transform.position + forward, Color.red);
      
            rb.MovePosition(transform.position + forward * Input.GetAxis("Vertical") * Time.fixedDeltaTime * speed);
   
         }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "plataforma") {
            suelo = true;
        }
    }


    


    void Morir() {
        muerto = true;
    }

}
