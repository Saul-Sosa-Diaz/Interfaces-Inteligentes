using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    public string type = "";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello I´m " + type);

    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log("Hello I´m " + type + " again!");  
    }
}
