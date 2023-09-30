using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer5 : MonoBehaviour
{   
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Transform ubicationObject = objeto.GetComponent<Transform>();
       Debug.Log("Distance beetween: " + name + " and " + objeto.name + " is: " + Vector3.Distance(transform.position, ubicationObject.position));

    }
}
