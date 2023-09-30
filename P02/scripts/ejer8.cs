using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejer8 : MonoBehaviour
{
    public GameObject toDistance;
    GameObject sphereWithMinDistance;
    GameObject sphereWitMaxDistance;
    GameObject[] spheres;

    // Start is called before the first frame update
    void Start()
    {
        
        if (spheres == null)
            spheres = GameObject.FindGameObjectsWithTag("spherenotsphere");
        
        float[] vector = new float[spheres.Length];

        float minDistance = 100000000000000;
        float maxDistance = -1;
        for (int i = 0; i < spheres.Length; i++) {
            float distance = Vector3.Distance(spheres[i].GetComponent<Transform>().position, toDistance.GetComponent<Transform>().position);
            vector[i] = distance;
            if (minDistance > distance) {
                minDistance = distance;
                sphereWithMinDistance = spheres[i];
            }
            if (maxDistance < distance) {
                maxDistance = distance;
                sphereWitMaxDistance = spheres[i];
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform positionSphere = sphereWithMinDistance.GetComponent<Transform>();
        Vector3 newposition = positionSphere.position +  new Vector3(0.0f,0.005f,0.0f);

        if (positionSphere.position.y <= 3.0f) { 
            positionSphere.position = Vector3.Lerp(positionSphere.position, newposition, 0.45f);
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Color newColor = new Color(UnityEngine.Random.Range(0.0f,0.9f),UnityEngine.Random.Range(0.0f,0.9f), UnityEngine.Random.Range(0.0f,0.9f));
            sphereWitMaxDistance.GetComponent<Renderer>().material.color = newColor;
        }

        
    }
}
