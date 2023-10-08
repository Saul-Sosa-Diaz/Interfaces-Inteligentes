using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ejer6 : MonoBehaviour
{   
    public GameObject cube;
    public GameObject sphere;

    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 moveDirectionCube = sphere.GetComponent<Transform>().position - cube.GetComponent<Transform>().position; // Target position - current position
        cube.transform.Translate(Vector3.Normalize(moveDirectionCube) * speed * Time.deltaTime);
        Vector3 moveDirectionSphere = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2")); 
        sphere.transform.Translate(moveDirectionSphere * speed * Time.deltaTime); 
  
    }
}
