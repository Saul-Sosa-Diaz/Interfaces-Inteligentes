using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        string tag = other.gameObject.tag;
        if (tag != "Untagged") {
            Debug.Log(tag); 
        }
    }
}
