using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ejer8 : MonoBehaviour
{   
    public GameObject objetive;

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        Vector3 forward = objetive.transform.TransformDirection(Vector3.forward) * 10000;
        Debug.DrawLine(objetive.transform.position, forward, Color.red);
        objetive.transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        //objetive.transform.forward;
    
        objetive.transform.Translate(transform.forward * speed * Time.deltaTime);

  
    }
}
