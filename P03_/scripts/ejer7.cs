using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ejer7 : MonoBehaviour
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
        Vector3 moveDirectionSphere = new Vector3(Input.GetAxis("Horizontal2"), 0, Input.GetAxis("Vertical2")); 
        Vector3 look = new Vector3(sphere.transform.position.x, cube.transform.position.y, sphere.transform.position.z);
        cube.transform.LookAt(look);
        sphere.transform.Translate(moveDirectionSphere * speed * Time.deltaTime); 
  
    }
}
