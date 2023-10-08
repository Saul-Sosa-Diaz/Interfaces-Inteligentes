using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer3 : MonoBehaviour
{
    public Vector3 moveDirection = new Vector3(0, 0, 0);
    public float speed = 5f;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {   
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {   

        transform.Translate(Vector3.Normalize(moveDirection) * speed, Space.World);
        
    }
}
