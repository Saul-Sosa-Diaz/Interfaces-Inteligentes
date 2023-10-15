using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer12 : MonoBehaviour
{
    public GameObject focus;
    public float speed = 9f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {

        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //rb.AddForce(m_Input*speed*Time.deltaTime*100);
        rb.MovePosition(transform.position + m_Input * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.X)) {
            // Mover gradualmente hacia la posición objetivo
            Vector3 newpos = Vector3.Lerp(transform.position, focus.transform.position, speed * Time.deltaTime);
            rb.MovePosition(newpos);
        }
    
    }

}
