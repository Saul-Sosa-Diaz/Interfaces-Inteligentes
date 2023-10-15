using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer1 : MonoBehaviour
{
    public float velocity = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Flecha izquierda: " + (horizontalInput * velocity).ToString());
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Flecha derecha: " + (horizontalInput * velocity).ToString());
        }
       
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Flecha arriba: " + (verticalInput * velocity).ToString());
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Flecha abajo: " + (verticalInput * velocity).ToString());   
        }
    }
}
