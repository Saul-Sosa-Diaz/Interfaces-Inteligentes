using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col) {
        string tag = col.gameObject.tag;
        if (tag != "Untagged") {
            Debug.Log(tag); 
        }

    }
}
