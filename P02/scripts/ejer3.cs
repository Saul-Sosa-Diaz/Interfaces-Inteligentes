using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer3 : MonoBehaviour
{
    public Vector3 vector1;
    public Vector3 vector2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.Log("Magnitude v1: " + vector1.magnitude.ToString());
        Debug.Log("Magnitude v2: " + vector2.magnitude.ToString());
        Debug.Log("Angle: " + Vector3.Angle(vector1, vector2).ToString());
        if ( vector1.y > vector2.y ) {
            Debug.Log("V1 is higher than v2");
        } else {
            Debug.Log("V2 is higher than v1");
        }
        
    }
}
