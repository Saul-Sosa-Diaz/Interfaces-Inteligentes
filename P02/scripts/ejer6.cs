using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer6 : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        left.transform.position = transform.position - new Vector3(5.0f,0.0f,0.0f);
        right.transform.position = transform.position + new Vector3(5.0f,0.0f,0.0f);
        
    }
}
