using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Transform ubication = GetComponent<Transform>();
      Debug.Log("Position of the sphere: " + ubication.position.ToString());  
    }
}
